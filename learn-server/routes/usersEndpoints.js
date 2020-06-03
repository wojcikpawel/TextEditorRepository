const router = require("express").Router();
const mongoose = require("mongoose");

//mongoose.model("User") - to wykorzystabe jest w ...
const User = mongoose.model("User");

//Pobranie wszystkich uzytkownikow z serwera
router.get("/", async (req, res) => {
    try {
        const users = await User.find({})
        
        res.send(users)
    } catch (error) {
        res.status(500)
    }
});

module.exports = router;