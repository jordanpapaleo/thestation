$(document).ready(function(){
   bindEvents(domEvents);
});

var domEvents = {
	"div.stylist-navigation li a" : {
		"click" : {
			handler: function(evt) {
                handleStylistBio(evt)
            }
        }
	},
    "div.services ul.horizontalNav a" : {
        "click" : {
            handler: function(evt) {
                handleServiceClick(evt);
            }
        }
    }
}

var bindEvents = function(map) {
     for (var address in map) {
          for (var action in map[address]) {
               $(address).live(action, map[address][action].handler);
          }
     }
}

var handleStylistBio = function(evt)
{
    $("div.gallery").hide().remove();
    var $el = $(evt.target);
    var stylistId = getStylistId($el);

    hideAllBios();

    if(stylistId)
    {
        showStylistBio(stylistId);
    }
}

var getStylistId = function($el)
{
    return $el.parent().attr("data-stylist");
}

var hideAllBios = function()
{
    $("div.bios li").hide();
}

var showStylistBio = function(stylistId)
{
    var $stylistBio = $("div.bios li[data-bio=" + stylistId + "]");
    $stylistBio.show();
}


var handleServiceClick = function(evt)
{
    var $el = $(evt.target);
    var serviceType = $el.attr("data-service");

    hideAllMenus();
    clearActiveLinks();

    $el.addClass("active");
    getServiceMenu(serviceType);
}

var hideAllMenus = function() 
{
    $("div.services div[data-service]").hide();
}

var clearActiveLinks = function()
{
    $("div.services ul.horizontalNav a").removeClass("active");
}

var getServiceMenu = function(serviceType)
{
    $("div.services div[data-service="+ serviceType +"]").show();
}