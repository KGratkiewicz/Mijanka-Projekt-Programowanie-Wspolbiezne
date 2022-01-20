using System;
using System.Threading;
using static Train;
/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Rails
{
	abstract public class Rail
    {
		private int length;
		protected SemaphoreSlim takeingTheRail;
		public Rail(int length)
		{
			this.length = length;
			this.takeingTheRail = new SemaphoreSlim(1, 1);
		}

		public int getLength()
        {
			return this.length;
        }
		abstract public void putTheTrain(Train train);
		abstract public void popTheTrain(Train train);
	}
	public class SingleRail : Rail
	{
		private SemaphoreSlim rail;
		private Train trainOnRail;
		public SingleRail(int length = 100) : base(length)
		{
			this.rail = new SemaphoreSlim(1, 1);
			this.trainOnRail = null;
		}

		public Train getTrain()
        {
			return this.trainOnRail;
        }

		override public void putTheTrain(Train train)
        {
			this.rail.Wait();
			this.takeingTheRail.Wait();
			this.trainOnRail = train;
			this.takeingTheRail.Release();
        }

		override public void popTheTrain(Train train)
		{
			this.takeingTheRail.Wait();
			this.trainOnRail = null;
			this.takeingTheRail.Release();
			this.rail.Release();
		}
	}

	public class DoubleRail : Rail
	{
		private SemaphoreSlim rail;
		private Train trainOnUpRail;
		private Train trainOnDownRail;
		public DoubleRail(int length = 100) : base(length)
		{
			this.rail = new SemaphoreSlim(2, 2);
			this.trainOnUpRail = null;
			this.trainOnDownRail = null;
		}

		public Train getTrainUp()
		{
			return this.trainOnUpRail;
		}

		public Train getTrainDown()
		{
			return this.trainOnDownRail;
		}

		override public void putTheTrain(Train train)
		{
			this.rail.Wait();
			this.takeingTheRail.Wait();
			if(this.trainOnUpRail == null)
            {
				this.trainOnUpRail = train;
            }
			else
            {
				this.trainOnDownRail = train;
			}
			this.takeingTheRail.Release();
		}

		override public void popTheTrain(Train train)
		{
			this.takeingTheRail.Wait();
			if (this.trainOnUpRail == train)
			{
				this.trainOnUpRail = null;
			}
			else
			{
				this.trainOnDownRail = null;
			}
			this.takeingTheRail.Release();
			this.rail.Release();
		}
	}
}

