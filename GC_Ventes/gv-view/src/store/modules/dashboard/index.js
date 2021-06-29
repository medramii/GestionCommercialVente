import Api from "../../api"
const END_POINT = 'Dashboard/';

const dashboard = {
    namespaced: true,
    state () {
        return {
            Ventes: [],
            Total: [],
            Livraisons: [],
        }
    },
    getters: {
        getVentes: (state) => state.Ventes,
        getTotal: (state) => state.Total,
        getLivraisons: (state) => state.Livraisons,
    },
    mutations: {
        setVentes: (state, payLoad) => state.Ventes = payLoad,
        setTotal: (state, payLoad) => state.Total = payLoad,
        setLivraisons: (state, payLoad) => state.Livraisons = payLoad,
    },
    actions: {
        initVentes: ({commit}, year) => {
            let tLocal = 0;
            let tExport = 0;
            return new Promise((resolve, reject) => {
                Api.get(END_POINT + "Ventes/" + year)
                .then((response) => {
                    response.data.forEach(el => {
                        tLocal += el.local || 0;
                        tExport += el.export || 0;
                    });
                    
                    let total = [
                        {
                            type: 'Local',
                            montant: tLocal.toFixed(2)
                        },
                        {
                            type: 'Export',
                            montant: tExport.toFixed(2)
                        }
                    ];

                    commit("setVentes", response.data);
                    commit("setTotal", total);

                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
        initLivraisons: ({commit}, date) => {
            let nfData = {
                facture: "Non Facturé",
                count: 0
            };
            let fData = {
                facture: "Facturé",
                count: 0
            };
            return new Promise((resolve, reject) => {
                Api.get(END_POINT + "Livraisons/" + date.start + "/" + date.end)
                .then((response) => {
                    response.data.forEach(el => {
                        if (el.facture == "Non Facturé") {
                            nfData = el;
                        } else {
                            fData.count += el.count;
                        }
                    });
                    commit("setLivraisons", [fData, nfData]);
                    resolve(response.data);
                })
                .catch((error) => {
                    reject(error);
                });
            });
        },
    }
};
export default dashboard