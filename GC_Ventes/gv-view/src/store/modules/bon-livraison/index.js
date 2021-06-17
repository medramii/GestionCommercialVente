import Api from "../../api"
const MAIN_END_POINT = 'BonLivraison/';
const LIGNESBL_END_POINT = 'LignesBonLivraison/';
const CLIENTS_END_POINT = 'Clients/';
const VILLES_END_POINT = 'Villes/';
const ARTICLES_END_POINT = 'Articles/';
const MAGSINS_END_POINT = 'Magasins/';

const bonLivraison = {
    namespaced: true,
    state () {
        return {
            BLs: [],
            BlInUse: [],
            LignesBl: [],
            NextBl: "",
            Clients: [],
            Villes: [],
            Articles: [],
            Magasins: [],
        }
    },
    getters: {
        getBLs: (state) => state.BLs,
        getBlInUse: (state) => state.BlInUse,
        getLignesBl: (state) => state.LignesBl,
        getNextBl: (state) => state.NextBl,
        getClients: (state) => state.Clients,
        getVilles: (state) => state.Villes,
        getArticles: (state) => state.Articles,
        getMagasins: (state) => state.Magasins,
    },
    mutations: {
        setBLs: (state, payLoad) => state.BLs = payLoad,
        setBlInUse: (state, payLoad) => state.BlInUse = payLoad,
        setLignesBl: (state, payLoad) => state.LignesBl = payLoad,
        setNextBl: (state, payLoad) => state.NextBl = payLoad,
        setClients: (state, payLoad) => state.Clients = payLoad,
        setVilles: (state, payLoad) => state.Villes = payLoad,
        setArticles: (state, payLoad) => state.Articles = payLoad,
        setMagasins: (state, payLoad) => state.Magasins = payLoad,
    },
    actions: {
        initBLs: ({commit}) => {
            return new Promise((resolve, reject) => {
                Api.get(MAIN_END_POINT)
                .then((response) => {
                    commit("setBLs", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
    /* -------------- for crud operations ------------------ */
        // for delete
        deleteBL: ({commit}, payLoad) => {
            console.log(!!commit);
            console.log(payLoad);
            return new Promise((resolve, reject) => {
                Api.delete(MAIN_END_POINT + payLoad)
                .then((response) => {
                    resolve(response);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        //for add and edit
        initDataForAdd: ({commit}) => {
            return new Promise((resolve, reject) => {
                // get next numBl
                Api.get(MAIN_END_POINT + "NextBl")
                .then((response) => {
                    commit("setNextBl", response.data);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
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

        addBL: ({getters}) => {
            let payload = getters.getLignesBl;
            let montantDH = 0;
            payload.forEach(article => montantDH += article.qte * article.prix)
                
            console.log(montantDH);

            let bl = {
                "numBl": getters.getBlInUse.numBl || '',
                "dateBl": getters.getBlInUse.dateBl || '',
                "codeClient": getters.getBlInUse.codeClient || '',
                "typeVente": getters.getBlInUse.typeVente || '',
                "idDestination": getters.getBlInUse.Destination || '',
                "idDevise": getters.getBlInUse.Devise || '',
                "observation": getters.getBlInUse.observation || '',
                "tauxDeChange": getters.getBlInUse.tauxDeChange || '',
                montantDH
            };
            
            return new Promise((resolve, reject) => {
                Api.post(MAIN_END_POINT, bl)
                .then((response) => {
                    payload.forEach(article => {
                        article["idBonLivraison"] = response.data.id;
                        article["montant"] = article.qte * article.prix;

                        Api.post(LIGNESBL_END_POINT, article)
                        .then((response) => {
                            resolve(response);
                        })
                        .catch((error) => {
                            reject(error);
                        });
                    }); 
                    resolve(response);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },

        initDataForUpdate: ({commit}, payload) => {
            console.log(payload);
            return new Promise((resolve, reject) => {
                // get next numBl
                Api.get(MAIN_END_POINT + payload)
                .then((response) => {
                    commit("setBlInUse", response.data);
                    commit("setLignesBl", response.data._0110LigneBonLivraisons);
                    commit("setNextBl", response.data.numBl);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
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

        editBL: ({getters}, id) => {
            console.log("Updating...");
            let payload = getters.getLignesBl;
            let montantDH = 0;
            payload.forEach(article => montantDH += article.qte * article.prix);
                
            console.log(montantDH);

            let bl = {
                id,
                "numBl": getters.getBlInUse.numBl || '',
                "dateBl": getters.getBlInUse.dateBl || '',
                "codeClient": getters.getBlInUse.codeClient || '',
                "typeVente": getters.getBlInUse.typeVente || '',
                "idDestination": getters.getBlInUse.Destination || '',
                "idDevise": getters.getBlInUse.Devise || '',
                "observation": getters.getBlInUse.observation || '',
                "tauxDeChange": getters.getBlInUse.tauxDeChange || '',
                montantDH
            };
            
            return new Promise((resolve, reject) => {
                Api.put(MAIN_END_POINT + id, bl)
                .then((response) => {
                    payload.forEach(article => {
                        article["idBonLivraison"] = id;
                        article["montant"] = article.qte * article.prix;

                        Api.post(LIGNESBL_END_POINT, article)
                        .then((response) => {
                            resolve(response);
                        })
                        .catch((error) => {
                            reject(error);
                        });
                    }); 
                    resolve(response);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
    }
};
export default bonLivraison