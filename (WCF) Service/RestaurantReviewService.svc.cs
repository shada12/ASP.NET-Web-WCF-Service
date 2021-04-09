using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Collections;
using System.Web.Hosting;


namespace Lab6Service
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RestaurantReviewService : IRestaurantReviewService
    {

      
        public List<string> GetRestaurantNames()
        {
            List<string> names = new List<string>();

            restaurants allRestaurants = GetRestaurantsFormXml();

            if (allRestaurants != null)
            {
                foreach (restaurant rest in allRestaurants.restaurant)
                {
                
                    names.Add(rest.name);

                }//foreach        

            }//if

            return names;
        
        }


        public RestaurantInfo GetRestaurantByName(string name)
        {
            restaurants allRestaurants = GetRestaurantsFormXml();

            RestaurantInfo restaurantInfo = new RestaurantInfo();
            Address address = new Address();

            for (int i = 0; i < allRestaurants.restaurant.Length; i++)
            {
                if (name == allRestaurants.restaurant[i].name)
                {

                    address.Street = allRestaurants.restaurant[i].location.street;

                    address.City = allRestaurants.restaurant[i].location.city;

                    address.Province = allRestaurants.restaurant[i].location.provstate;

                    address.PostalCode = allRestaurants.restaurant[i].location.postalzipcode;

                    restaurantInfo.Name = allRestaurants.restaurant[i].name;
                    restaurantInfo.Summary = allRestaurants.restaurant[i].summary;

                    restaurantInfo.Rating = allRestaurants.restaurant[i].rating;
                    restaurantInfo.Location = address;
                }
            }

            return restaurantInfo;

        }


         public List<RestaurantInfo> GetRestaurantsByRating(int rating)
       // public RestaurantInfo[] GetRestaurantsByRating(int rating)
       
        {
            restaurants allRestaurants = GetRestaurantsFormXml();

            
             //RestaurantInfo[]  restaurantsInfo = new RestaurantInfo[2];

            List<RestaurantInfo> restaurantsInfo = new List<RestaurantInfo>();

            for (int i = 0; i < allRestaurants.restaurant.Length; i++)
            {
                if ( allRestaurants.restaurant[i].rating >= rating)
                {
                    RestaurantInfo restaurantInfo = new RestaurantInfo();
                    Address address = new Address();


                    address.Street = allRestaurants.restaurant[i].location.street.ToString();

                    address.City = allRestaurants.restaurant[i].location.city.ToString();

                    address.Province = allRestaurants.restaurant[i].location.provstate;

                    address.PostalCode = allRestaurants.restaurant[i].location.postalzipcode.ToString();

                    restaurantInfo.Name = allRestaurants.restaurant[i].name;
                    restaurantInfo.Summary = allRestaurants.restaurant[i].summary.ToString();

                    restaurantInfo.Rating = allRestaurants.restaurant[i].rating;
                    restaurantInfo.Location = address;

                    restaurantsInfo.Add(restaurantInfo);

                }
            }

            return restaurantsInfo;
        }


        public bool SaveRestaurant(RestaurantInfo restInfo)
        {

            bool saveResult = false;
            restaurants allRestaurants = GetRestaurantsFormXml();


            for (int i = 0; i < allRestaurants.restaurant.Length; i++)
            {
                if (allRestaurants.restaurant[i].name == restInfo.Name)
                {
   

                    allRestaurants.restaurant[i].summary = restInfo.Summary;

                    allRestaurants.restaurant[i].rating = restInfo.Rating;

                    allRestaurants.restaurant[i].location.street = restInfo.Location.Street;
                    allRestaurants.restaurant[i].location.city = restInfo.Location.City;
                    allRestaurants.restaurant[i].location.provstate = restInfo.Location.Province;
                    allRestaurants.restaurant[i].location.postalzipcode = restInfo.Location.PostalCode;  

                    saveResult = true;

                }
            }


            XmlSerializer serializor = new XmlSerializer(typeof(restaurants));
            XmlTextWriter tw = new XmlTextWriter("C:/temp/restaurant_reviews.xml", Encoding.UTF8);

            serializor.Serialize(tw, allRestaurants);
            tw.Close();

            return saveResult;
        }

        public restaurants GetRestaurantsFormXml()
        {

            FileStream xs = new FileStream("C:/temp/restaurant_reviews.xml", FileMode.Open);//1+2
            XmlSerializer serializor = new XmlSerializer(typeof(restaurants));

            restaurants restaurnts = (restaurants)serializor.Deserialize(xs);

            xs.Close();
            return restaurnts;

        }


    }
}
