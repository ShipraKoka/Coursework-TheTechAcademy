$(document).ready(function(){
	$("li").mouseover(function(){
		$(this).find("ul>li").fadeIn(500);
	});
	$("li").mouseleave(function(){
		$(this).find("ul>li").hide();
	});
	
});

/*
$(document).ready(function(){
	$("li").mouseover(function(){
		$("ul>li").slideDown(500);
	});
	$("li").mouseleave(function(){
		$("ul>li").slideUp();
	});
	
});
*/