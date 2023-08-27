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
    public class VideoAndAboutManager : IVideoAndAboutService
    {
        private readonly IVideoAndAboutDal _videoAndAboutDal;

        public VideoAndAboutManager(IVideoAndAboutDal videoAndAboutDal)
        {
            _videoAndAboutDal = videoAndAboutDal;
        }

        public void TDelete(VideoAndAbout t)
        {
            _videoAndAboutDal.Delete(t);

        }

        public VideoAndAbout TGetByID(int id)
        {
            return _videoAndAboutDal.GetByID(id);
        }

        public List<VideoAndAbout> TGetList()
        {
           return _videoAndAboutDal.GetList();
        }

        public void TInsert(VideoAndAbout t)
        {
            _videoAndAboutDal.Insert(t);
        }

        public void TUpdate(VideoAndAbout t)
        {
            _videoAndAboutDal.Update(t);
        }
    }
}
