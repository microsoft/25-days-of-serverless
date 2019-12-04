
const secret ="santa";
const repo = "/home/25-days-of-serverless/week-1/challenge-3/ImageWebhook";

const http = require('http');
const crypto = require('crypto');

http.createServer(function(req, res){
   req.on('data', function(chunk){
        let sig = "sha1" + crypto.createHmac('sha1', secret).update(chunk.toString()).digest('hex');

	    if(req.headers['x-hub-signature'] == sig){
			 console.log('getting POST');			 
	    }
   });
   res.end();
}).listen(8080);

