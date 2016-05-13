<?php

//$name = session_name("session1");
//echo "<pre>";
//print_r($name);
//echo "</pre>";
session_start();
if(!isset($_SESSION['firstName']))
{
	$_SESSION['firstName'] = $_POST['firstname'];
	$_SESSION['lastName'] = $_POST['lastname'];
}


echo "<pre>";
print_r($_SESSION);
echo "</pre>";

//If submit submitPersonal button
//is clicked it will connect to the 
//database and insert the customer's
//information into the dbo.Demographic table
if(isset($_POST['submitPersonal']))
{
	$firstName = $_SESSION['firstName'];
	$lastName = $_SESSION['lastName'];
	$dateOfBirth = $_POST['dob'];
	$plateNumber = $_POST['plateregistrationnumber'];
	$cardNumber = $_POST['cardnumber'];
	$securityCode = $_POST['cvc#'];


	
    $connectionInfo = array("Database"=>"ParkALotDatabase","UID"=>"db2", "PWD"=>"db20");

	$dbc = sqlsrv_connect("cis1.actx.edu", $connectionInfo);


	

	$query = "INSERT INTO dbo.Demographic (FirstName, LastName, DateOfBirth, PlateNumber, CreditCardNumber)
	          VALUES ('$firstName', '$lastName', '$dateOfBirth', '$plateNumber', '$cardNumber');";


	$results = sqlsrv_query($dbc, $query);

	

	header("Location: reservation.html");
	exit();
}
else if(isset($_POST['submitReservation']))
{
	//Submit the information to the reservation table
	$dateOfReservation = $_POST['dateOfReservation'];
	$timeIn = $_POST['timein'];
	$timeOut = $_POST['timeout'];
	$firstName = $_SESSION['firstName'];
	$lastName = $_SESSION['lastName'];


	$connectionInfo = array("Database"=>"ParkALotDatabase","UID"=>"db2", "PWD"=>"db20");

	$dbc = sqlsrv_connect("cis1.actx.edu", $connectionInfo);

if( $dbc ) {
     echo "Connection established.<br />";
}else{
     echo "Connection could not be established.<br />";
     die( print_r( sqlsrv_errors(), true));
}

	$query = "SELECT TOP 1 CustomerID FROM dbo.Demographic
			  WHERE FirstName = '$firstName'
			  AND LastName = '$lastName';";


	$results = sqlsrv_query($dbc, $query);



$custId = 0;
	while($row = sqlsrv_fetch_array($results, SQLSRV_FETCH_ASSOC)) {



	$custId = $row['CustomerID'];

}
	$query = "INSERT INTO dbo.Reservation (CustomerID, DayOfReservation, TimeIn, TimeOut)
			  VALUES ('$custId', '$dateOfReservation', '$timeIn', '$timeOut');";

	$results = sqlsrv_query($dbc, $query);

	echo "<p>Reservation Successfully made</p>";




}



	
?>