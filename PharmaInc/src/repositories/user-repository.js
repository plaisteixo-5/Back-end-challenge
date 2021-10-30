const mongoose = require('mongoose');
const User = mongoose.model('User');

exports.getAll = async () => {
    const response = await User.find({});

    return response;
};

exports.getById = async (id) => {
    const response = await User.find({
        _id: id
    });

    return response;
};

exports.create = async (data) => {
    var user = new User(data);

    const response = await user.save();

    return response;
};

exports.delete = async (id) => {
    const response = await User
        .findOneAndRemove(id)

    return response;
};