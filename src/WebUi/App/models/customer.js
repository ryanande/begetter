// *** Generated Code by T4Durandal: 04/06/2014 18:11:17
// *** Based on WebUi.Models.Customer
define(['knockout'], function (ko) {
	return function (raw) {
		var self = this;
		this.Id = ko.observable();
		this.FirstName = ko.observable();
		this.LastName = ko.observable();
		this.Email = ko.observable();
		
			
		this.update = function(data) { 
			self.Id(data.Id);
			self.FirstName(data.FirstName);
			self.LastName(data.LastName);
			self.Email(data.Email);
			
        };

        self.update(raw);
    };
});
