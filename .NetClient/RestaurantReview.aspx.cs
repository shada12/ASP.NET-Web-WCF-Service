using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Text;
using Lab6DotNetClient.Lab6Service;

public partial class RestaurantReview : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        lblConfirmation.Visible = false;
        pnlViewRestaurant.Visible = false;

        RestaurantReviewServiceClient reviewer = new RestaurantReviewServiceClient();

        string[] retaurantName = reviewer.GetRestaurantNames();

        if (!IsPostBack)
        {
            drpRestaurants.Items.Insert(0, new ListItem("Select One", "-1"));

            for (int i = 0; i < retaurantName.Length; i++)
            {
                ListItem item = new ListItem(retaurantName[i], i.ToString());

                drpRestaurants.Items.Add(item);

            }
        }
    }

    protected void drpRestaurants_SelectedIndexChanged(object sender, EventArgs e)
    {

        RestaurantReviewServiceClient reviewer = new RestaurantReviewServiceClient();

        string[] retaurantName = reviewer.GetRestaurantNames();

        if (drpRestaurants.SelectedValue != "-1")
        {
            string restaurantName = drpRestaurants.SelectedItem.Text;

            for (int i = 0; i < retaurantName.Length; i++)
            {
                if (restaurantName == retaurantName[i])
                {

                    RestaurantInfo restaurantInfo = reviewer.GetRestaurantByName(restaurantName);

                    txtAddress.Text = restaurantInfo.Location.Street;

                    txtCity.Text = restaurantInfo.Location.City;

                    txtProvinceState.Text = restaurantInfo.Location.Province;

                    txtPostalZipCode.Text = restaurantInfo.Location.PostalCode;

                    txtSummary.Text = restaurantInfo.Summary;

                    drpRating.SelectedValue = restaurantInfo.Rating.ToString();
                }
            }

            pnlViewRestaurant.Visible = true;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

        RestaurantReviewServiceClient reviewer = new RestaurantReviewServiceClient();

        string[] retaurantName = reviewer.GetRestaurantNames();

        RestaurantInfo restaurantInfo = new RestaurantInfo();

        if (drpRestaurants.SelectedValue != "-1")
        {
            string restaurantName = drpRestaurants.SelectedItem.Text;

            for (int i = 0; i < retaurantName.Length; i++)
            {
                if (restaurantName == retaurantName[i])
                {
                    restaurantInfo = reviewer.GetRestaurantByName(restaurantName);

                    restaurantInfo.Summary = txtSummary.Text;

                    restaurantInfo.Rating = Int32.Parse(drpRating.Text);

                }
            }

            bool saveconfirmation = reviewer.SaveRestaurant(restaurantInfo);

            if (saveconfirmation)
            {
                lblConfirmation.Text = "Revised Resturent Review has been saved";

            }
            else
            {
                lblConfirmation.Text = "Unable to save the revised restaurant review ";
            }

            lblConfirmation.Visible = true;
            pnlViewRestaurant.Visible = true;
        }
    }
}