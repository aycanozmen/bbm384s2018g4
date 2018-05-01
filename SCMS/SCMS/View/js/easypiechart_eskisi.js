/**!
 * easyPieChart
 * Lightweight plugin to render simple, animated and retina optimized pie charts
 *
 * @license Dual licensed under the MIT (http://www.opensource.org/licenses/mit-license.php) and GPL (http://www.opensource.org/licenses/gpl-license.php) licenses.
 * @author Robert Fleischmann <rendro87@gmail.com> (http://robert-fleischmann.de)
 * @version 2.0.1
 **/
CountDownTimer('April 20, 2015 13:00:00');

function CountDownTimer(date) {
    var end       = new Date(date);
    
    var _second   = 1000;
    var _minute   = _second * 60;
    var _hour     = _minute * 60;
    var _day      = _hour * 24;
    var timer;
    
    var showRemaining = function() {
        var now = new Date();
        var distance = end - now;

        if (distance < 0) {   
            clearInterval(timer);
            document.getElementById(day).innerHTML = '0';
            document.getElementById(hour).innerHTML = '0';
	    document.getElementById(minute).innerHTML = '0';
            return;
        }

        var days = Math.floor(distance / _day);
        var hours = Math.floor((distance % _day) / _hour);
        var minutes = Math.floor((distance % _hour) / _minute);
		var seconds = Math.floor((distance % _minute) / _second);
        
	var day_percent = Math.floor((minute*100) / 60);
        var hour_percent = Math.floor((minute*100) / 60);
        var minute_percent = Math.floor((minute*100) / 60);

	document.getElementById("cday").setAttribute("data-percent", "100");

        document.getElementById("day").innerHTML = days;
        document.getElementById("hour").innerHTML = hours;
        document.getElementById("minute").innerHTML = minutes;
	document.getElementById("second").innerHTML = seconds;
	bizimchart.update(10);
    };
    
    timer = setInterval(showRemaining, 1000);

}

window.addEventListener('DOMContentLoaded', function() {
		    var element = document.querySelector('.chart');
    new EasyPieChart(element, defaultOptions);
		});

var EasyPieChart = function(el, opts) {
var defaultOptions = {
barColor: '#ef1e25',
trackColor: '#f9f9f9',
scaleColor: '#dfe0e0',
scaleLength: 5,
lineCap: 'round',
lineWidth: 3,
trackWidth: undefined,
size: 110,
rotate: 0,
animate: {
duration: 1000,
enabled: true
},
easing: function (x, t, b, c, d) { // more can be found here: http://gsgd.co.uk/sandbox/jquery/easing/
t = t / (d/2);
if (t < 1) {
return c / 2 * t * t + b;
}
return -c/2 * ((--t)*(t-2) - 1) + b;
},
onStart: function(from, to) {
return;
},
onStep: function(from, to, currentValue) {
return;
},
onStop: function(from, to) {
return;
}
};
// detect present renderer
if (typeof(CanvasRenderer) !== 'undefined') {
defaultOptions.renderer = CanvasRenderer;
} else if (typeof(SVGRenderer) !== 'undefined') {
defaultOptions.renderer = SVGRenderer;
} else {
throw new Error('Please load either the SVG- or the CanvasRenderer');
}
var options = {};
var currentValue = 0;
/**
* Initialize the plugin by creating the options object and initialize rendering
*/
var init = function() {
this.el = el;
this.options = options;
// merge user options into default options
for (var i in defaultOptions) {
if (defaultOptions.hasOwnProperty(i)) {
options[i] = opts && typeof(opts[i]) !== 'undefined' ? opts[i] : defaultOptions[i];
if (typeof(options[i]) === 'function') {
options[i] = options[i].bind(this);
}
}
}
// check for jQuery easing
if (typeof(options.easing) === 'string' && typeof(jQuery) !== 'undefined' && jQuery.isFunction(jQuery.easing[options.easing])) {
options.easing = jQuery.easing[options.easing];
} else {
options.easing = defaultOptions.easing;
}
// process earlier animate option to avoid bc breaks
if (typeof(options.animate) === 'number') {
options.animate = {
duration: options.animate,
enabled: true
};
}
if (typeof(options.animate) === 'boolean' && !options.animate) {
options.animate = {
duration: 1000,
enabled: options.animate
};
}
// create renderer
this.renderer = new options.renderer(el, options);
// initial draw
this.renderer.draw(currentValue);
// initial update
if (el.dataset && el.dataset.percent) {
this.update(parseFloat(el.dataset.percent));
} else if (el.getAttribute && el.getAttribute('data-percent')) {
this.update(parseFloat(el.getAttribute('data-percent')));
}
}.bind(this);
/**
* Update the value of the chart
* @param {number} newValue Number between 0 and 100
* @return {object} Instance of the plugin for method chaining
*/
this.update = function(newValue) {
newValue = parseFloat(newValue);
if (options.animate.enabled) {
this.renderer.animate(currentValue, newValue);
} else {
this.renderer.draw(newValue);
}
currentValue = newValue;
return this;
}.bind(this);
/**
* Disable animation
* @return {object} Instance of the plugin for method chaining
*/
this.disableAnimation = function() {
options.animate.enabled = false;
return this;
};
/**
* Enable animation
* @return {object} Instance of the plugin for method chaining
*/
this.enableAnimation = function() {
options.animate.enabled = true;
return this;
};
init();
};
