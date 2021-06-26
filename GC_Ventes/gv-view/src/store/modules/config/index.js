import Api from "../../api"
const CLIENTS_END_POINT = 'Clients/';
const VILLES_END_POINT = 'Villes/';
const ARTICLES_END_POINT = 'Articles/';
const MAGSINS_END_POINT = 'Magasins/';
const DEVISES_END_POINT = 'Devise/';
const MODES_REG_END_POINT = 'ModeReglement/';

const config = {
    namespaced: true,
    state () {
        return {
            Clients: [],
            Villes: [],
            Articles: [],
            Magasins: [],
            Devises: [],
            ModesReglement: [],
        }
    },
    getters: {
        getClients: (state) => state.Clients,
        getVilles: (state) => state.Villes,
        getArticles: (state) => state.Articles,
        getMagasins: (state) => state.Magasins,
        getDevises: (state) => state.Devises,
        getModesReglement: (state) => state.ModesReglement,
    },
    mutations: {
        setClients: (state, payLoad) => state.Clients = payLoad,
        setVilles: (state, payLoad) => state.Villes = payLoad,
        setArticles: (state, payLoad) => state.Articles = payLoad,
        setMagasins: (state, payLoad) => state.Magasins = payLoad,
        setDevises: (state, payLoad) => state.Devises = payLoad,
        setModesReglement: (state, payLoad) => state.ModesReglement = payLoad,
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
                // get devises
                Api.get(DEVISES_END_POINT)
                .then((response) => {
                    commit("setDevises", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
                // get modes reglement
                Api.get(MODES_REG_END_POINT)
                .then((response) => {
                    commit("setModesReglement", response.data);
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