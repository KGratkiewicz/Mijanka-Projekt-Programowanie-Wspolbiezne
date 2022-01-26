using System;
using System.Threading;
using Rails;
using static Train;

/// <summary>
/// Summary description for Class1
/// </summary>
public class FractionAB
{
	private SemaphoreSlim trains;
	private SingleRail railA;
	private DoubleRail doubleRail;
	private SingleRail railB;
	private int delay;
	public FractionAB(int delay = 100)
	{
		this.trains = new SemaphoreSlim(2, 2);
		this.delay = delay;
		this.railA = new SingleRail(300);
		this.doubleRail = new DoubleRail(300);
		this.railB = new SingleRail(300);
	}

	public void Simulation()
    {
		this.createNewTrain(5);
		this.createNewTrain(10);
		this.createNewTrain(-10);
		this.createNewTrain(-25);
	}

	public void changeSimulationSpeed(int delay)
    {
		this.delay = delay;
    }

	public SingleRail getRailA()
    {
		return this.railA;
    }

	public DoubleRail getDoubleRail()
	{
		return this.doubleRail;
	}

	public SingleRail getRailB()
    {
		return this.railB;
    }

	public bool createNewTrain(int speed)
    {
		if (speed != 0)
        {
			Thread threadTrain = new Thread(threadTrainFunction);
			threadTrain.Start((Object)speed);
			return true;
        }
		return false;
    }

	private void threadTrainFunction(Object speed)
    {
		this.trains.Wait();
		Train newTrain = new Train((int)speed);
		if(newTrain.getSpeed() > 0)
        {
			goAB(newTrain);
        }
		else
		{
			goBA(newTrain);
		}
		this.trains.Release();
	}

	private void goAB(Train train)
    {
		train.getOnTheRail(this.railA);
		train.rideRail(this.delay);

		train.getOnTheNextRail(this.doubleRail);
		train.rideRail(this.delay);

		train.getOnTheNextRail(this.railB);
		train.rideRail(this.delay);

		train.getOffTheRail();
	}

	private void goBA(Train train)
	{
		train.getOnTheRail(this.railB);
		train.rideRail(this.delay);

		train.getOnTheNextRail(this.doubleRail);
		train.rideRail(this.delay);

		train.getOnTheNextRail(this.railA);
		train.rideRail(this.delay);

		train.getOffTheRail();
	}
}
