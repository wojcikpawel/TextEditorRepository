const router = require("express").Router();
const mongoose = require("mongoose");
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
/*
router.post("/", async (req, res) => {
    try {
        const post = new Post();
        post.title = req.body.title;
        post.content = req.body.content;
        await post.save();
        res.send(post)
    } catch (error) {
        res.status(500)
    }

})*/

module.exports = router;