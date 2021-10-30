const express = require('express');
const router = express.Router();

router.get('/', (req, res, next) => {
    res.status(200).send("REST Back-end Challenge 20201209 Running");
});

module.exports = router;