$(document).ready(function(){
	$(".menu").mouseenter(function(){
		$(".dropdown").stop(true, true).slideDown(500);
	});
	$(".menu").mouseleave(function(){
		$(".dropdown").stop(true, true).slideUp(500);
	});
});
