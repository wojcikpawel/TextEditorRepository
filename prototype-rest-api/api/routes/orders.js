const express = require('express');
const router = express.Router();
var util = require('util');

router.get('/', (req, res, next) => {
    res.status(200).json({
        message: 'Orders were fetched'
    });
});

router.post('/', (req, res, next) => {
    res.status(201).json({
        message: 'Order was created'
    });
});

/*
router.get('/:orderId', (req, res, next) => {
    res.status(200).json({
        message: 'Order details',
        orderId: req.params.orderId
    });
});
*/

router.delete('/:orderId', (req, res, next) => {
    res.status(200).json({
        message: 'Order deleted',
        orderId: req.params.orderId
    });
});

router.get('/siemanko', function(req, res, next){
  res.send('ello');
});

router.get('/hej', function(req, res, next) {
  //object or variable
  var params = req.query;
 // var params2 = req.query.lastName;

  console.log('query ='+util.inspect(params));
 // console.log('query = '+util.inspect(params2));

  params.name = 'andrzej';
 // params2.lastName = 'sapkowski';

  res.send({params: params});
 //
 // res.send(params);
});

router.post('/goodmorning', function(req, res, next){
    res.send('byebye');
});

router.post('/logowanie', function(req, res, next){
  var body = req.body;
  body.login = 'jacek';
  //body.pass = 'brak';
  res.send(body);
});

module.exports = router;