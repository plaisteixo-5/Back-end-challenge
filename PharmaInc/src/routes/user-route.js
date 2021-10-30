const express = require('express');
const router = express.Router();
const controller = require('../controllers/user-controller');

router.get('/', controller.getAll);
router.get('/:id', controller.getById);
router.put('/', controller.create);
router.delete('/:id', controller.delete);

module.exports = router;