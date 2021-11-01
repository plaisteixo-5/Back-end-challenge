const axios = require('axios');
const cron = require('node-cron');
const Update = require('./update-database');
const {
    SERVER_PORT,
    DB_HOST
} = process.env;

module.exports = () => {

    cron.schedule('*/1 * * * *', async () => {
        try {
            const response = await Update();

            await axios({
                method: 'put',
                url: `http://localhost:${SERVER_PORT}/users/v1/`,
                data: response.data
            });
        } catch (error) {
            console.log('Algo deu errado ao requisitar da API Random User');
            console.log(error);
        }
    })
};