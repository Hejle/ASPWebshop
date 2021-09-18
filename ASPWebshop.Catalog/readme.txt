Setup Docker

* Get MongoDB
	docker pull mongo

* Initialize Container
	docker run -d -p 27017:27017 --name "catalogdb" mongo
