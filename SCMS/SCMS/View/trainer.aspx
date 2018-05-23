<%@ Page Language="C#" AutoEventWireup="true" CodeFile="trainer.aspx.cs" Inherits="SCMS.View.trainer" %>


<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js"> <!--<![endif]-->
	<head>
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<title>Fitness &mdash;ŞAUMİ</title>


	<link href='https://fonts.googleapis.com/css?family=Roboto:400,100,300,700,900' rel='stylesheet' type='text/css'>
	
	<!-- Animate.css -->
	<link rel="stylesheet" href="css/animate.css">
	<!-- Icomoon Icon Fonts-->
	<link rel="stylesheet" href="css/icomoon.css">
	<!-- Bootstrap  -->
	<link rel="stylesheet" href="css/bootstrap.css">
	<!-- Superfish -->
	<link rel="stylesheet" href="css/superfish.css">

	<link rel="stylesheet" href="css/style.css">


	<!-- Modernizr JS -->
	<script src="js/modernizr-2.6.2.min.js"></script>
	<!-- FOR IE9 below -->
	<!--[if lt IE 9]>
	<script src="js/respond.min.js"></script>
	<![endif]-->

	</head>
	<body>
		<div id="fh5co-wrapper">
		<div id="fh5co-page">
		<div id="fh5co-header">
			<header id="fh5co-header-section">
				<div class="container">
					<div class="nav-header">
						<a href="index.aspx" class="js-fh5co-nav-toggle fh5co-nav-toggle"><i></i></a>
						<h1 id="fh5co-logo"><a href="index.html">ŞAUMI<span><br>Sports Center<br /></span></a></h1>
						<!-- START #fh5co-menu-wrap -->
						<nav id="fh5co-menu-wrap" role="navigation">
							<ul class="sf-menu" id="fh5co-primary-menu">
								<li>
									<a href="index.aspx">Home</a>
								</li>
								<li>
									<a href="classes.aspx" class="fh5co-sub-ddown">Classes</a>
									 <ul class="fh5co-sub-menu">
									 	<li><a href="classes.aspx">Boxing</a></li>
									 	<li><a href="classes.aspx">Yoga</a></li>
										<li><a href="classes.aspx">Body Building</a></li>
										<li><a href="classes.aspx">Swimming</a></li>
										<li><a href="classes.aspx">Cycling</a></li> 
									</ul>
								</li>
							
								<li><a href="trainer.aspx">Trainers</a></li>
								<li><a href="about.aspx">About</a></li>
							</ul>
						</nav>
					</div>
				</div>
			</header>		
		</div>
		<!-- end:fh5co-header -->
		<div class="fh5co-parallax" style="background-image: url(images/personalTrainer.jpg);" data-stellar-background-ratio="1">
			<div class="overlay"></div>
			<div class="container">
				<div class="row">
					<div class="col-md-8 col-md-offset-2 col-sm-12 col-sm-offset-0 col-xs-12 col-xs-offset-0 text-center fh5co-table">
						<div class="fh5co-intro fh5co-table-cell animate-box">
							<h1 class="text-center">Trainers</h1>
							<p>You can see our trainers below.<br>Click on them to get more information.<br /> </p>
						</div>
					</div>
				</div>
			</div>
		</div><!-- end: fh5co-parallax -->
		<!-- end:fh5co-hero -->
		<div id="fh5co-team-section" class="fh5co-lightgray-section">
			<div class="container">
				<div class="row">
					<div class="col-md-8 col-md-offset-2">
						<div class="heading-section text-center animate-box">
							<h2>Meet Our Trainers</h2>
							<p>-------</p>
						</div>
					</div>
				</div>
				<div class="row text-center">
					<div class="col-md-4 col-sm-6">
						<div class="team-section-grid animate-box" style="background-image: url(images/bodybuilding.jpg);">
							<div class="overlay-section">
								<div class="desc">
									<h3>Edward Bishop</h3>
									<span>Body Trainer</span>
									<p>Get stronger...</p>
									<p class="fh5co-social-icons">
										<a href="#"><i class="icon-twitter-with-circle"></i></a>
										<a href="#"><i class="icon-facebook-with-circle"></i></a>
										<a href="#"><i class="icon-instagram-with-circle"></i></a>
									</p>
								</div>
							</div>
						</div>
					</div>
					<div class="col-md-4 col-sm-6">
						<div class="team-section-grid animate-box" style="background-image: url(images/swimmingtrainer.jpg);">
							<div class="overlay-section">
								<div class="desc">
									<h3>Lydia John</h3>
									<span>Swimming Trainer</span>
									<p>Swim like a dolphin...</p>
									<p class="fh5co-social-icons">
										<a href="#"><i class="icon-twitter-with-circle"></i></a>
										<a href="#"><i class="icon-facebook-with-circle"></i></a>
										<a href="#"><i class="icon-instagram-with-circle"></i></a>
									</p>
								</div>
							</div>
						</div>
					</div>
					<div class="col-md-4 col-sm-6">
						<div class="team-section-grid animate-box" style="background-image: url(images/yogatrainer.jpg);">
							<div class="overlay-section">
								<div class="desc">
									<h3>Samantha White</h3>
									<span>Yoga</span>
									<p>Meditation and sports together... What could be better...</p>
									<p class="fh5co-social-icons">
										<a href="#"><i class="icon-twitter-with-circle"></i></a>
										<a href="#"><i class="icon-facebook-with-circle"></i></a>
										<a href="#"><i class="icon-instagram-with-circle"></i></a>
									</p>
								</div>
							</div>
						</div>
					</div>
					<div class="col-md-4 col-sm-6">
						<div class="team-section-grid animate-box" style="background-image: url(images/cyclingtrainer.jpg);">
							<div class="overlay-section">
								<div class="desc">
									<h3>Thomas Danforth</h3>
									<span>Cycling Trainer</span>
									<p>Be fastest on land...</p>
									<p class="fh5co-social-icons">
										<a href="#"><i class="icon-twitter-with-circle"></i></a>
										<a href="#"><i class="icon-facebook-with-circle"></i></a>
										<a href="#"><i class="icon-instagram-with-circle"></i></a>
									</p>
								</div>
							</div>
						</div>
					</div>
					<div class="col-md-4 col-sm-6">
						<div class="team-section-grid animate-box" style="background-image: url(images/boxingtrainer.jpg);">
							<div class="overlay-section">
								<div class="desc">
									<h3>Katie Wilder</h3>
									<span>Boxing Trainer</span>
									<p>Knock out!...</p>
									<p class="fh5co-social-icons">
										<a href="#"><i class="icon-twitter-with-circle"></i></a>
										<a href="#"><i class="icon-facebook-with-circle"></i></a>
										<a href="#"><i class="icon-instagram-with-circle"></i></a>
									</p>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		
		
		
		<!-- fh5co-blog-section -->
		<footer>
			<div id="footer">
				<div class="container">
					<div class="row">
						<div class="col-md-4 animate-box">
							<h3 class="section-title">About Us</h3>
							<p>Far far away, behind the word mountains, far from the countries....</p>
						</div>

						<div class="col-md-4 animate-box">
							<h3 class="section-title">Our Address</h3>
							<ul class="contact-info">
								<li><i class="icon-map-marker"></i>Hacettepe Beytepe</li>
								<li><i class="icon-phone"></i>+1234 5678</li>
								<li><i class="icon-envelope"></i><a href="#">info@saumi.com</a></li>
								<li><i class="icon-globe2"></i><a href="#">www.saumi.com</a></li>
							</ul>
						</div>
						
					</div>
					<div class="row copy-right">
						<div class="col-md-6 col-md-offset-3 text-center">
							<p class="fh5co-social-icons">
								<a href="#"><i class="icon-twitter2"></i></a>
								<a href="#"><i class="icon-facebook2"></i></a>
								<a href="#"><i class="icon-instagram"></i></a>
								<a href="#"><i class="icon-dribbble2"></i></a>
								<a href="#"><i class="icon-youtube"></i></a>
							</p>
							<p>Copyright 2018 <a href="#">Fıtness</a>. All Rights Reserved. <br>Made with <i class="icon-heart3"></i> by ŞAUMİ</p>
						</div>
					</div>
				</div>
			</div>
		</footer>
	

	</div>
	<!-- END fh5co-page -->

	</div>
	<!-- END fh5co-wrapper -->

	<!-- jQuery -->


	<script src="js/jquery.min.js"></script>
	<!-- jQuery Easing -->
	<script src="js/jquery.easing.1.3.js"></script>
	<!-- Bootstrap -->
	<script src="js/bootstrap.min.js"></script>
	<!-- Waypoints -->
	<script src="js/jquery.waypoints.min.js"></script>
	<!-- Stellar -->
	<script src="js/jquery.stellar.min.js"></script>
	<!-- Superfish -->
	<script src="js/hoverIntent.js"></script>
	<script src="js/superfish.js"></script>

	<!-- Main JS (Do not remove) -->
	<script src="js/main.js"></script>

	</body>
</html>
