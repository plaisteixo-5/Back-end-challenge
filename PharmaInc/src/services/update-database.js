const axios = require('axios');

module.exports = async () => {
    const data = await axios(`https://randomuser.me/api`);
    
    return data;
};