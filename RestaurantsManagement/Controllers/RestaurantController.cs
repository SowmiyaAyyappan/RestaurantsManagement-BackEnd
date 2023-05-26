using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantsManagement.Data;
using RestaurantsManagement.Models;

namespace RestaurantsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public RestaurantController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        //read all

        [HttpGet]
        public async Task<ActionResult<List<Restaurant>>> GetRestaurants()
        {
            var restaurants = await appDbContext.Restaurants.ToListAsync();
            return Ok(restaurants);

        }
        //read single

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
        {
            var restaurant = await appDbContext.Restaurants.FirstOrDefaultAsync(e => e.Id == id);
            if (restaurant != null)
            {
                return Ok(restaurant);
            }
            return NotFound();
        }

        //add

       /* [HttpPost]
        public async Task<ActionResult<List<Restaurant>>> AddRestaurant(Restaurant newRestaurant)
        {
            if (newRestaurant != null)
            {

                appDbContext.Restaurants.Add(newRestaurant);
                await appDbContext.SaveChangesAsync();

                var restaurants = await appDbContext.Restaurants.ToListAsync();
                return Ok(restaurants);

            }
            return BadRequest();
        }


        //delete

        [HttpDelete]
        public async Task<ActionResult<List<Restaurant>>> DeleteEmployee(int id)
        {
            var restaurant = await appDbContext.Restaurants.FirstOrDefaultAsync(e => e.Id == id);
            if (restaurant != null)
            {
                appDbContext.Restaurants.Remove(restaurant);
                await appDbContext.SaveChangesAsync();

                var restaurants = await appDbContext.Restaurants.ToListAsync();
                return Ok(restaurants);

            }
            return BadRequest();
        }

        //update

        [HttpPut]
        public async Task<ActionResult<Restaurant>> UpdateRestaurant(Restaurant updatedRestaurant)
        {
            if (updatedRestaurant != null)
            {
                var restaurant = await appDbContext.Restaurants.FirstOrDefaultAsync(e => e.Id == updatedRestaurant.Id);
                if (restaurant != null)
                {
                    restaurant.RestaurantName = updatedRestaurant.RestaurantName;
                    restaurant.RestaurantLocation = updatedRestaurant.RestaurantLocation;
                    restaurant.StarRating = updatedRestaurant.StarRating;
                    restaurant.Cuisine = updatedRestaurant.Cuisine;
                    restaurant.Category = updatedRestaurant.Category;
                    restaurant.ContactNumber = updatedRestaurant.ContactNumber;
                    restaurant.Image = updatedRestaurant.Image;
                    await appDbContext.SaveChangesAsync();

                    var restaurants = await appDbContext.Restaurants.ToListAsync();
                    return Ok(restaurants);

                }
                return NotFound();
            }
            return BadRequest();
        }*/
    }
}

