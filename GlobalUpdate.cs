using System.Threading;
using System.Collections.Generic;
using Backend.Objects;
using System.Numerics;
using System.Linq;
namespace Backend
{
    public class GlobalUpdate
    {
        private List<BaseObject> _objects = new ();

        private Thread _thread;
        public GlobalUpdate()
        {
            Test();

            _thread = new Thread(new ThreadStart(this.ThreadTask));
            // _thread.IsBackground = true;
            _thread.Start();
        }

        private void Test()
        {
            _objects.Add(new BaseObject(){
                Id = 1,
                Name = "TestObject",
                Position = new Vector3(0,0,0)
            });
            _objects.ForEach(x => x.Start());
        }

        private void ThreadTask()
        {
            while (true)
            {
                _objects.ForEach(x => x.Update());
                Thread.Sleep (1);
            }
        }
    }
}