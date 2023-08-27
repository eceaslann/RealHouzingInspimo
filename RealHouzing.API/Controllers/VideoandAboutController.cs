using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.DtoLayer.VideoandAboutDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoandAboutController : ControllerBase
    {
        private readonly IVideoAndAboutService _videoandAboutService;

        public VideoandAboutController(IVideoAndAboutService videoandAboutService)
        {
            _videoandAboutService = videoandAboutService;
        }

        [HttpGet]
        public IActionResult VideoandAboutList()
        {
            var values = _videoandAboutService.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddVideo(AddVideoDto p)
        {
            VideoAndAbout videoandAbout = new VideoAndAbout()
            {
                Title = p.Title,
                Description = p.Description,
                VideoURL = p.VideoURL,

            };
            _videoandAboutService.TInsert(videoandAbout);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideo(int id)
        {
            var values = _videoandAboutService.TGetByID(id);
            _videoandAboutService.TDelete(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetVideo(int id)
        {
            var values = _videoandAboutService.TGetByID(id);
            return Ok(values);

        }

        [HttpPut]
        public IActionResult UpdateVideo(UpdateVideoDto p)
        {
            VideoAndAbout videoandAbout = new VideoAndAbout()
            {
                VideoAndAboutID = p.VideoandAboutID,
                Title = p.Title,
                Description = p.Description,
                VideoURL = p.VideoURL,

            };

            _videoandAboutService.TUpdate(videoandAbout);
            return Ok();
        }

    }
}