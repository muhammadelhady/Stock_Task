using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repos.Interface
{
    public interface IHangFireRepo
    {
        public Task Update();
        public Task Generate();
        public Task GenerateDummyData();

    }
}
