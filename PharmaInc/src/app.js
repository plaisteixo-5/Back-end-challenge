const express = require('express');
const mongoose = require('mongoose');
const config = require('./config');

const app = express();

mongoose.connect(config.connectionString);

const User = require('./models/user');

const indexRoute = require('./routes/index-route');
const userRoute = require('./routes/user-route');

app.use(express.json());
app.use(express.urlencoded({
    extended: false
}));

app.use('/', indexRoute);
app.use('/users', userRoute);

module.exports = app;