/* Add event handler to HTML document ready event to perform the following tasks
 
 1. Populate the restaurant name dropdown list.
 Make an ajax call to the php script Site.php to get the names of the restaurants.
 
 2. Attach the event handler to handle the restaurant name dropdown list's selection changed event.
 Make an ajax call to the php script Site.php to get the selected restaurant data
 
 3. Attach the event handler to handle the Save button clicked event.
 Make an ajax call to the php script Site.php to save the user modified restaurant data
 
 */

$(document).ready(function () {

    var url = "Site.php";

    $("#drpRestaurant").empty();
    $("#drpRestaurant").append("<option>loading...</option>");

    $.ajax({
        type: "Post",
        url: "Site.php?action=getRestNames",
        // contentType:"application/jason; charset=utf-8",
        dataType: "json",

        success: function (data) {

            $("#drpRestaurant").empty();
            $("#drpRestaurant").append("<option value = '0'>Select Country</option>");

            $drpRestaurant = $("#drpRestaurant");

            $.each(data, function (index, value) {

                var displayText = value.restaurantname;

                $drpRestaurant.append($("<option />").val(index).text(displayText));

            });
            for (var i = 1; i < 6; i++) {
                $('#drpRating').append($("<option />").val(i).text(i));
            }
        }//, //success
    });  //ajax

    $("#drpRestaurant").on("change", function (e) {

        var selectedValue = $("#drpRestaurant").find(":selected").text();

        if (selectedValue != -1) {

            $.ajax({
                type: "Post",
                url: "Site.php?action=getRestInfo",
                // contentType:"application/jason; charset=utf-8",
                dataType: "json",
                data: 
                 {
                    restoNameStr: selectedValue
                 },

                success: function (data) {

                         $('#txtStreetAddress').val(data.streetAddress);
                         $('#txtCity').val(data.city);
                        $('#txtProvinceState').val(data.provinceState);
                        $('#txtPostalZipCode').val(data.postalZipCode);
                        $('#txtSummary').val(data.summary);
                        $('#drpRating').val(data.drpRating);

                     
                }//success
            });//Ajax
        }//if selectedValue != -1
    }); //onChange

    $('#btnSave').on('click', function () {

       
        var selectedValue = $("#drpRestaurant").find(":selected").text();
        var streetAddrss = $('#txtStreetAddress').val();
        var city = $('#txtCity').val();
        var province = $('#txtProvinceState').val();
        var postal = $('#txtPostalZipCode').val();
        var summary = $('#txtSummary').val();
        var rating = $('#drpRating').val();


        $.ajax({
            type: "POST",
            url: "Site.php?action=save",
            dataType: "JSON",
            data: {
                restoNameStr: selectedValue,
                streetStr: streetAddrss,
                cityStr: city,
                provinceStr: province,
                postalStr: postal,
                summaryStr: summary,
                ratingStr: rating

            },

            success: function (confirmation) {

                $('#lblConfirmation').text(JSON.stringify(confirmation));

            }//success
        });//Ajax
    });//save btn
}); //document

