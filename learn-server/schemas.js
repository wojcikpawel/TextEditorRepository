const mongoose = require("mongoose");

const post_schema =  new mongoose.Schema({
    /*title: {
        type: String,
        required: true
    },
    content: {
        type: String,
        required: true
    }*/
    post_id: Number,
    post_name: String,
    post_content: String
   // post_creation_date: GetDateTime(),
   // post_update_date: GetDateTime()
})

//pierwszy sposób exportu modelu - schema
//module.exports = mongoose.model("Post", post_schema)

//drugi sposób Franek exportu modelu - schema
exports.posts = mongoose.model("Post", post_schema);

const user_schema = new mongoose.Schema({
    user_id: Number,
    user_login: String,
    user_password: String
});
//exports.users - to jest wykorzystane do ..., monoose.model("User",user_schema) - to jest wykorzystane do ...
exports.users = mongoose.model("User", user_schema);