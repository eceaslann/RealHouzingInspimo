using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class WhatWeDoManager : IWhatWeDoService
    { private readonly IWhatWeDoDal _whatwedoDal;
        public WhatWeDoManager(IWhatWeDoDal whatwedoDal)
        {
            _whatwedoDal = whatwedoDal;
        }

        public void TDelete(WhatWeDo t)
        {
            _whatwedoDal.Delete(t);
        }

        public WhatWeDo TGetByID(int id)
        {
            return _whatwedoDal.GetByID(id);
        }

        public List<WhatWeDo> TGetList()
        {
            return _whatwedoDal.GetList();
        }

        public void TInsert(WhatWeDo t)
        {
            _whatwedoDal.Insert(t);
        }

        public void TUpdate(WhatWeDo t)
        {
            _whatwedoDal.Update(t);
        }
    }
}
