const repository = require('../repositories/user-repository');

exports.getAll = async (req, res, next) => {
    try {
        var data = await repository.getAll();
        res.status(200).send(data);
    } catch (err) {
        res.status(500).send({
            message: 'Falha ao processar a requisição!'
        });
    }
};

exports.getById = async (req, res, next) => {
    try {
        const response = await repository.getById(req.params.id);
        res.status(200).send(response);
    } catch (err) {
        res.status(500).send({
            message: 'Falha ao processar a requisição!'
        });
    }
};

exports.create = async (req, res, next) => {
    try {
        let response = await repository.create(req.body);
        res.status(200).send(response);
    } catch (err) {
        res.status(500).send({
            message: 'Falha ao processar a requisição!'
        });
    }
};

exports.updateDatabase = async (req, res, next) => {
    try {
        repository.create(req.body.results[0]);

        console.log('Usuário adicionado com sucesso!');
    } catch (err) {
        console.log('Falha ao processar a requisição!');
    }
}

exports.delete = async (req, res, next) => {
    try {
        let response = await repository.delete(req.params.id);

        res.status(200).send(response);
    } catch (err) {
        res.status(500).send({
            message: 'Falha ao processar a requisição!'
        });
    }
};