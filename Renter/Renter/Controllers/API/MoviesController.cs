using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Renter.Database;
using Renter.Dtos;
using Renter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Renter.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private Context _context;
        private readonly IMapper _mapper;

        public MoviesController(IMapper mapper)
        {
            _context = new Context();
            _mapper = mapper;
        }

        //GET /api/movies
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies.ToList().Select(_mapper.Map<Movie, MovieDto>);
        }


        [HttpGet("{id}")]
        public ActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(x => x.Id == id);

            if (movie == null) return NotFound();

            return Ok(_mapper.Map<Movie, MovieDto>(movie));
        }

        [HttpPost]
        public ActionResult CreateMovie(MovieDto movie)
        {
            if (!ModelState.IsValid) return BadRequest();

            var movieDto = _mapper.Map<MovieDto, Movie>(movie);
            _context.Movies.Add(movieDto);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.Host + Request.Path + movie.Id), movieDto);

        }

        [HttpPut("{id}")]
        public void UpdateMovie(int id, MovieDto movie)
        {
            if (!ModelState.IsValid) throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if(movieInDb == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            _mapper.Map(movie, movieInDb);

            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieInDb == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);

            _context.SaveChanges();
        }
    }
}
