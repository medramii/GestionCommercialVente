import Api from "../../api"
const MAIN_END_POINT = 'BonLivraison/';

const bonLivraison = {
    namespaced: true,
    state () {
        return {
            BLs: [],
            BlInUse: [],
            LignesBl: [],
            NextBl: "",
        }
    },
    getters: {
        getBLs: (state) => state.BLs,
        getBlInUse: (state) => state.BlInUse,
        getLignesBl: (state) => state.LignesBl,
        getNextBl: (state) => state.NextBl,
    },
    mutations: {
        setBLs: (state, payLoad) => state.BLs = payLoad,
        setBlInUse: (state, payLoad) => state.BlInUse = payLoad,
        setLignesBl: (state, payLoad) => state.LignesBl = payLoad,
        setNextBl: (state, payLoad) => state.NextBl = payLoad,
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
        //for add
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
            });
        },

        addBL: ({getters}) => {
            let lignesBl = getters.getLignesBl;
            let montantDH = 0;
            
            lignesBl.forEach(article => {
                article["montant"] = article.qte * article.prix;
                montantDH += article.qte * article.prix;
            });

            let bl = {
                "numBl": getters.getBlInUse.numBl || '',
                "dateBl": getters.getBlInUse.dateBl || '',
                "codeClient": getters.getBlInUse.codeClient || '',
                "typeVente": getters.getBlInUse.typeVente || '',
                "idDestination": getters.getBlInUse.Destination || '',
                "idDevise": getters.getBlInUse.Devise || '',
                "observation": getters.getBlInUse.observation || '',
                "tauxDeChange": getters.getBlInUse.tauxDeChange || '',
                montantDH,
                "_0110LigneBonLivraisons": lignesBl
            };

            return new Promise((resolve, reject) => {
                Api.post(MAIN_END_POINT, bl)
                .then((response) => {
                    resolve(response);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        //for edit
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
            });
        },

        editBL: ({getters}, id) => {
            let lignesBl = getters.getLignesBl;
            let montantDH = 0;
            
            lignesBl.forEach(article => {
                article["montant"] = article.qte * article.prix;
                montantDH += article.qte * article.prix;
            });

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
                montantDH,
                "_0110LigneBonLivraisons": lignesBl
            };
            return new Promise((resolve, reject) => {
                Api.put(MAIN_END_POINT + id, bl)
                .then((response) => { 
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