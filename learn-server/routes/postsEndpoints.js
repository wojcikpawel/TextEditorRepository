const router = require("express").Router();
const mongoose = require("mongoose");
const express = require("express");
const app = express();
//var postControllers = require('../controllers/postControllers');
//mongoose.model("Post") - to wykorzystabe jest w ...
const Post = mongoose.model("Post")

//Pobranie wszystkich pocztówek z serwera
router.get("/", async (req, res) => {
    try {
      
        
      //  postControllers.get_all_posts(function(err,result){

     //   });
       // studentsRepo.getStudentById(studentId, function(err, result){
//
      //  });
        const posts = await Post.find({}) // wydaje mi się że te metody find, findOne, findByIdAndUpdate, create powinny być w controller!
        res.send(posts)
       // res.json(posts)
    } catch (error) {
        res.status(500)
    }
});

module.exports= function(app)
{
    const list = require('../controllers/postsController');
};

app.route('/postswww').get(list.get_all_posts);

/*
module.exports = function(app){
    const list = require('../controller/APIcontroller');

app.route('/documents').get(list.list_all_documents().post(list.create_document()));

app.route('/documents:documentId').get(list.read_document()).put(list.update_document()).delete(list.delete_document());

}
*/

//Pobranie jednej pocztówki o określonym id z serwera
router.get("/:postId", async (req, res) => {
    try {
        const post = await Post.findOne({ _id: req.params.postId })
        res.send(post)
    } catch (error) {
        res.status(500);
    }
});
/*
router.put("/:postId", async (req, res) => {
    try {
        const post = await Post.findByIdAndUpdate({
            _id: req.params.postId
        }, req.body, {
            new: true,
            runValidators: true
        });

        res.send(post)

    } catch (error) {
        res.send(500)
    }
});
*/
/*
router.delete("/:postId", async (req, res) => {
  try {
      const post = await Post.findByIdAndRemove({
          _id: req.params.postId
      });
      res.send(post)

  } catch (error) {
      res.send(500)
  }
})
*/

router.post("/", async (req, res) => {
    try {
        const post = new Post();
       // post.title = req.body.title;
       // post.content = req.body.content;

        post.post_id = req.body.post_id;
        post.post_name = req.body.post_name;

        await post.save();//zapis do Mongo Database wartości z żądania METODĄ POST
        res.send(post)
    } catch (error) {
        res.status(500)
    }

})

module.exports = router;