<?php

$appConfigs = parse_ini_file("Lab6.ini");
$reviewWsdl = $appConfigs["restaurantReviewServiceWsdl"];
$reviewClient = new SoapClient($reviewWsdl);

if ($_GET["action"] == "getRestNames") {

    $names = array();
    $restNames = $reviewClient->GetRestaurantNames();
    $restNames = $restNames->GetRestaurantNamesResult;
    $restNames = $restNames->string;

    for ($i = 0; $i < count($restNames); $i++) {

        $names[] = array("restaurantname" => "$restNames[$i]");
    }

    $names;
    echo json_encode($names);
}

if ($_GET["action"] == "getRestInfo") {

    $address = array();
    $restoNameStr = $_POST["restoNameStr"];
    $parameters = new stdClass;
    $parameters->name = $restoNameStr;

    $rest = $reviewClient->GetRestaurantByName($parameters);
    $rest = $rest->GetRestaurantByNameResult;


    $name = $rest->Name;
    $street = $rest->Location->Street;
    $city = $rest->Location->City;
    $provstate = $rest->Location->Province;
    $postalzipcode = $rest->Location->PostalCode;
    $summary = $rest->Summary;
    $rating = $rest->Rating;

    $address = array(
        "restaurantname" => "$name",
        "streetAddress" => "$street",
        "city" => "$city",
        "provinceState" => "$provstate",
        "postalZipCode" => "$postalzipcode",
        "summary" => "$summary",
        "drpRating" => "$rating")
    ;

    
    echo json_encode($address);
}

if ($_GET["action"] == "save") {

    $confirmation;

     $rest = new stdClass();
     
     $rest->Name = $_POST["restoNameStr"];

     $rest->Location = new stdClass();   

    $rest->Name = $_POST["restoNameStr"];
    $rest->Location->Street = $_POST["streetStr"];
    $rest->Location->City = $_POST["cityStr"];
    $rest->Location->Province = $_POST["provinceStr"];
    $rest->Location->PostalCode = $_POST["postalStr"];
    $rest->Summary = $_POST["summaryStr"];
    $rest->Rating = $_POST["ratingStr"];

    $parameters = new stdClass;
    $parameters->restInfo = $rest;

    $saveResult = $reviewClient->SaveRestaurant($parameters);
    $saveResult = $saveResult->SaveRestaurantResult;

   if ($saveResult) {

        $confirmation = "Revise restaurant review has been saved";
       
    } else {
        $confirmation = "Unable to save the revised restaurant review ";
        
    }

 echo json_encode($confirmation);
}    
?>

