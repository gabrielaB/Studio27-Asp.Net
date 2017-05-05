using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio27SalonOfBeauty.Data;

namespace Studio27SalonOfBeauty.Services
{
    public  class Service
    {
        private Studio27Context context;

        protected Service()
        {
            this.context = new Studio27Context();
        }

        public Studio27Context Context => this.context;
    }
}
