FROM node:14-alpine3.10
WORKDIR /backend-challenge
COPY package.json /backend-challenge
RUN npm install
COPY . /backend-challenge
CMD ["npm", "start"]