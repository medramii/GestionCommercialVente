import Api from "../../api"
const CLIENTS_END_POINT = 'Clients/';
const VILLES_END_POINT = 'Villes/';
const ARTICLES_END_POINT = 'Articles/';
const MAGSINS_END_POINT = 'Magasins/';

const config = {
    namespaced: true,
    state () {
        return {
            Clients: [],
            Villes: [],
            Articles: [],
            Magasins: [],
        }
    },
    getters: {
        getClients: (state) => state.Clients,
        getVilles: (state) => state.Villes,
        getArticles: (state) => state.Articles,
        getMagasins: (state) => state.Magasins,
    },
    mutations: {
        setClients: (state, payLoad) => state.Clients = payLoad,
        setVilles: (state, payLoad) => state.Villes = payLoad,
        setArticles: (state, payLoad) => state.Articles = payLoad,
        setMagasins: (state, payLoad) => state.Magasins = payLoad,
    },
    actions: {
        initConfig: ({commit}) => {
            return new Promise((resolve, reject) => {
                // get clients
                Api.get(CLIENTS_END_POINT)
                .then((response) => {
                    commit("setClients", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
                // get villes
                Api.get(VILLES_END_POINT)
                .then((response) => {
                    commit("setVilles", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
                // get articles
                Api.get(ARTICLES_END_POINT)
                .then((response) => {
                    commit("setArticles", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
                // get magasins
                Api.get(MAGSINS_END_POINT)
                .then((response) => {
                    commit("setMagasins", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
    }
};
export default config