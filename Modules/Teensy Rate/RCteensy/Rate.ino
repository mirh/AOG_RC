volatile unsigned long Duration[MaxProductCount];
volatile unsigned long Durations[2][12];
volatile byte DurCount[2];
volatile unsigned long avDurs[2];
volatile int avgPulses = 12;

volatile unsigned long PulseCount[MaxProductCount];
volatile bool FullCount[MaxProductCount];

uint32_t LastPulse[MaxProductCount];

uint32_t RateInterval[MaxProductCount];
uint32_t RateTimeLast[MaxProductCount];
uint32_t PWMTimeLast[MaxProductCount];

unsigned long CurrentCount;
uint32_t CurrentDuration;

unsigned long PPM[MaxProductCount];		// pulse per minute * 100
unsigned long Osum[MaxProductCount];
unsigned long Omax[MaxProductCount];
unsigned long Omin[MaxProductCount];
byte Ocount[MaxProductCount];
float Oave[MaxProductCount];

void ISR0()
{
	static unsigned long PulseTime;
	unsigned long micronow;
	unsigned long dur;

	micronow = micros();
	if (PulseTime > micronow)
	{
		dur = micronow - PulseTime;
	}
	else
	{
		dur = 0xFFFFFFFF + micronow - PulseTime;
	}

	if (dur > 2000000)
	{
		// the component was off so reset the values
		avDurs[0] = 0;
		dur = 50000;
		for (int i = 0; i < avgPulses; i++)
		{
			Durations[0][i] = 0;
		}
		DurCount[0] = 0;
		FullCount[0] = false;

		PulseTime = micronow;
		PulseCount[0]++;
	}
	else if (dur > Sensor[0].Debounce * 1000)
	{
		if (avDurs[0] == 0) avDurs[0] = dur;

		// check to see if the dur value is too long like an interrupt was missed.
		if (dur > (2.5 * avDurs[0])) dur = avDurs[0];

		Duration[0] = dur;
		Durations[0][DurCount[0]] = dur;

		if (DurCount[0] > 0)
		{
			avDurs[0] = ((Durations[0][DurCount[0] - 1]) + dur) / 2;
		}
		else
		{
			// use last duration to average
			avDurs[0] = ((Durations[0][avgPulses - 1]) + dur) / 2;
		}

		if (++DurCount[0] >= avgPulses)
		{
			DurCount[0] = 0;
			FullCount[0] = true;
		}

		PulseTime = micronow;
		PulseCount[0]++;
	}
}

void ISR1()
{
	static unsigned long PulseTime;
	unsigned long micronow;
	unsigned long dur;

	micronow = micros();
	if (PulseTime > micronow)
	{
		dur = micronow - PulseTime;
	}
	else
	{
		dur = 0xFFFFFFFF + micronow - PulseTime;
	}

	if (dur > 2000000)
	{
		// the component was off so reset the values
		avDurs[1] = 0;
		dur = 50000;
		for (int i = 0; i < avgPulses; i++)
		{
			Durations[1][i] = 0;
		}
		DurCount[1] = 0;
		FullCount[1] = false;

		PulseTime = micronow;
		PulseCount[1]++;
	}
	else if (dur > Sensor[1].Debounce * 1000)
	{
		if (avDurs[1] == 0) avDurs[1] = dur;

		// check to see if the dur value is too long like an interrupt was missed.
		if (dur > (2.5 * avDurs[1])) dur = avDurs[1];

		Duration[1] = dur;
		Durations[1][DurCount[1]] = dur;

		if (DurCount[1] > 0)
		{
			avDurs[1] = ((Durations[1][DurCount[1] - 1]) + dur) / 2;
		}
		else
		{
			// use last duration to average
			avDurs[1] = ((Durations[1][avgPulses - 1]) + dur) / 2;
		}

		if (++DurCount[1] >= avgPulses)
		{
			DurCount[1] = 0;
			FullCount[1] = true;
		}

		PulseTime = micronow;
		PulseCount[1]++;
	}
}


void GetUPM()
{
	for (int i = 0; i < MDL.SensorCount; i++)
	{
		if (Sensor[i].ControlType == 3)
		{
			// use weight
			Sensor[i].UPM = Sensor[i].MeterCal * (double)Sensor[i].pwmSetting;
		}
		else
		{
			// use flow meter
			GetUPMflow(i);
		}
	}
}

unsigned long GetAvgDuration(int ID)
{
	unsigned long dursum = 0;

	noInterrupts();
	for (int i = 0; i < avgPulses; i++)
	{
		dursum += Durations[ID][i];
	}
	interrupts();
	return dursum / avgPulses;
}

void GetUPMflow(int ID)
{
	if (PulseCount[ID])
	{
		noInterrupts();
		CurrentCount = PulseCount[ID];
		PulseCount[ID] = 0;
		CurrentDuration = Duration[ID];
		interrupts();

		if (Sensor[ID].UseMultiPulses)
		{
			// low ms/pulse, use pulses over time
			if (FullCount[ID])
			{
				PPM[ID] = 6000000000 / GetAvgDuration(ID);
			}
			else
			{
				PPM[ID] = 0;
			}
		}
		else
		{
			// high ms/pulse, use time for one pulse
			if (CurrentDuration == 0)
			{
				PPM[ID] = 0;
			}
			else
			{
				// high ms/pulse, use time for one pulse
				if (CurrentDuration == 0)
				{
					PPM[ID] = 0;
				}
				else
				{
					PPM[ID] = 6000000000 / CurrentDuration;
				}
			}
		}

		LastPulse[ID] = millis();
		Sensor[ID].TotalPulses += CurrentCount;
	}

	// check for no flow
	if (millis() - LastPulse[ID] > 2000)
	{
		PPM[ID] = 0;
		Osum[ID] = 0;
		Oave[ID] = 0;
		Ocount[ID] = 0;
	}

	// olympic average
	Osum[ID] += PPM[ID];
	if (Omax[ID] < PPM[ID]) Omax[ID] = PPM[ID];
	if (Omin[ID] > PPM[ID]) Omin[ID] = PPM[ID];

	Ocount[ID]++;
	if (Ocount[ID] > 4)
	{
		Osum[ID] -= Omax[ID];
		Osum[ID] -= Omin[ID];
		Oave[ID] = (float)Osum[ID] / 300.0;	// divide by 3 samples and divide by 100 for decimal place
		Osum[ID] = 0;
		Omax[ID] = 0;
		Omin[ID] = 5000000000;
		Ocount[ID] = 0;
	}

	// units per minute
	if (Sensor[ID].MeterCal > 0)
	{
		Sensor[ID].UPM = (float)Oave[ID] / (float)Sensor[ID].MeterCal;
	}
	else
	{
		Sensor[ID].UPM = 0;
	}
}


