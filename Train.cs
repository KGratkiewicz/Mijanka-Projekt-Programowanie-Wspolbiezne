using System;
using Rails;
using System.Threading;
public class Train
{
	private int speed;
	private int location;
	private Rail rail;
	public Train(int speed = 1)
	{
		this.speed = speed;
		this.location = 0;
	}

	public int getSpeed()
	{
		return this.speed;
	}
	
	public int getLocation()
    {
		return this.location;
    }

	public Rail getRail()
    {
		return this.rail;
    }

	public void getOnTheRail(Rail rail)
    {
		rail.putTheTrain(this);
		this.rail = rail;
		this.location = (this.speed > 0) ? 0 : this.rail.getLength();
		
    }

	public void getOnTheNextRail(Rail nextRail)
	{
		Rail oldRail = this.rail;
		nextRail.putTheTrain(this);
		this.rail = nextRail;
		oldRail.popTheTrain(this);
		this.location = (this.speed > 0) ? 0 : this.rail.getLength();

	}

	public void getOffTheRail()
    {
		this.rail.popTheTrain(this);
		this.rail = null;
    }

	public void rideRail(int delay)
    {
		if(this.speed > 0)
        {
			while(this.location < this.rail.getLength())
            {
				this.location += speed;
				System.Threading.Thread.Sleep(delay);
            }
			this.location = this.rail.getLength();
        }
		else
		{
			while (this.location > 0)
			{
				this.location += speed;
				System.Threading.Thread.Sleep(delay);
			}
			this.location = 0;
		}

	}

}
