// *** Generated Code by T4Durandal: 04/06/2014 18:11:17
// *** Based on System.Net.Http.HttpResponseMessage
define(['knockout'], function (ko) {
	return function (raw) {
		var self = this;
		this.Content = ko.observable();
		this.Headers = ko.observable();
		this.IsSuccessStatusCode = ko.observable();
		this.ReasonPhrase = ko.observable();
		this.RequestMessage = ko.observable();
		this.StatusCode = ko.observable();
		this.Version = ko.observable();
		
			
		this.update = function(data) { 
			self.Content(data.Content);
			self.Headers(data.Headers);
			self.IsSuccessStatusCode(data.IsSuccessStatusCode);
			self.ReasonPhrase(data.ReasonPhrase);
			self.RequestMessage(data.RequestMessage);
			self.StatusCode(data.StatusCode);
			self.Version(data.Version);
			
        };

        self.update(raw);
    };
});
