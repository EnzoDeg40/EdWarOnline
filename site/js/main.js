jQuery(function($){

	var launch = new Date(2018, 08, 08, 16, 00, 00);

	var days = $('#days');
	var hours = $('#hours');
	var minutes = $('#minutes');
	var seconds = $('#seconds');

	setDate();
	function setDate(){
		var now = new Date();
		var s = -now.getTimezoneOffset()*60 + (launch.getTime() - now.getTime())/1000;
		var d = Math.floor(s/86400);
		days.html((d<10?'0':'')+'<strong>'+d+'</strong>');
		s -= d*86400;

		var h = Math.floor(s/3600);
		hours.html((h<10?'0':'')+'<strong>'+h+'</strong>');
		s -= h*3600;

		var m = Math.floor(s/60);
		minutes.html((m<10?'0':'')+'<strong>'+m+'</strong>');
		
		var s = Math.floor(s-m*60);
		seconds.html((s<10?'0':'')+'<strong>'+s+'</strong>');
		setTimeout(setDate,1000);
	}

});