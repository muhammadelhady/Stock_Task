using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repos.Interface
{
    public interface IHangFireRepo
    {
        public Task<bool> Update();
        public Task<bool> Generate();

    }
}
