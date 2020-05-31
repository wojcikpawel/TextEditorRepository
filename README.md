# Text Editor Application

## Table of contents
* [General Info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Features](#features)
* [Running Desktop Application](#running-desktop-application)
* [Library](#library)
* [Additional](#additional)
* [Native Application](#native-application-desktop-windows-forms)

## NativeAppClient
![NativeAppClientPicture](./Images/NativeAppClient.jpg)

* utworzenie nowego pliku
* wyświetlenie pliku
* edycja pliku
* wysłanie zedytowanych plików na serwer
* pobranie listy plików z serwera
* komunikacja z serwerem odbywa się za pomocą REST API

## WebAppClient
![WebAppClient](./Images/WebAppClient.jpg)
* Running Web Application:
```sh

```
* Web App runs on
http://localhost:3000/ || http://127.0.0.1:3000

## Server Node.js Web Server
* Node.js Web Server - https://nodejs.org/en/docs/guides/getting-started-guide/
* Running Node.js Web Server:
```sh
node app.js
```
* Node.js HTTP Module - https://www.w3schools.com/nodejs/nodejs_http.asp

* mongoose - https://mongoosejs.com/ || https://github.com/Automattic/mongoose || https://www.npmjs.com/package/mongoose
* Install mongoose:
```sh
npm install mongoose
```
* Install body-parser
```sh
npm install body-parser
```
* Server runs on
http://localhost:5000/
current url: http://localhost:5000/orders

* Info
127.0.0.1:5000 = localhost:5000

## Database MongoDB
* MongoDB Official - https://www.mongodb.com/ | https://www.npmjs.com/package/mongodb
* Mongo Help - https://zellwk.com/blog/local-mongodb/ | http://jsdn.pl/podstawy-mongodb/
* MongoDB Compass - https://www.mongodb.com/download-center/compass
* MongoDB Documentation - https://docs.mongodb.com/manual/reference/method/db.collection.insert/#examples
* Install MongoDB:
```sh
npm install mongodb
```
* Check version:
```sh
mongo -version
```
* Running Databse Server:
```sh
mongod --dbpath .
```
* Running Process Database - Interaction with MongoDB:
```sh
mongo
```
* Running MongoDB Compass:
```sh
C:\Program Files\MongoDB Compass\MongoDBCompass.exe
```
* To connect to your local MongoDB:
```sh
Hostname: localhost
Port: 27017
URL: mongodb://127.0.0.1:27017
```

* Commands:
```sh
db
```
```sh
show dbs
```
```sh
use <database>
```
```sh
db.<collectionName>.insert({name: "Paul"})
```
```sh
db.<collectionName>.insert({name: 'Mark'})
```
```sh
db.<collectionName>.insertOne({ name: "Jax" })
```
```sh
db.<collectionName>.insertOne({ name: 'Jon Snow' })
```
```sh
db.<collectionName>.find()
```
```sh
show tables 
```
```sh
show collections
```

## REST Application Programming Interface

## WebSocket
* Install WebSocket:
```sh
npm install ws
```
* https://www.websocket.org/echo.html
* https://www.npmjs.com/package/ws
* Websocket Demos: https://codepen.io/matt-west/pen/tHlBb
* Documentation socket.io: https://socket.io/docs/
## Additional
* .NET components:
  * MenuStrip
  * SaveFileDialog
  * OpenFileDialog
  * Button
  * GroupBox
  * PictureBox
  * RichTextBox
  * DataGridView
