import Api from "../../api"
const END_POINT = 'Dashboard/';

const dashboard = {
    namespaced: true,
    state () {
        return {
            Ventes: [],
            Total: []
        }
    },
    getters: {
        getVentes: (state) => state.Ventes,
        getTotal: (state) => state.Total,
    },
    mutations: {
        setVentes: (state, payLoad) => state.Ventes = payLoad,
        setTotal: (state, payLoad) => state.Total = payLoad,
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
                            montant: tLocal
                        },
                        {
                            type: 'Export',
                            montant: tExport
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
    }
};
export default dashboard