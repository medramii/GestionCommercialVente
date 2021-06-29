import Api from "../../api"
import allPages from '../../../app-navigation';

const END_POINT = 'WebDroitUsers/UserPages/';

const pages = {
    namespaced: true,
    state () {
        return {
            accessiblePages: [],
        }
    },
    getters: {
        getPages: (state) => state.accessiblePages,
    },
    mutations: {
        setPages: (state, payLoad) => state.accessiblePages = payLoad,
    },
    actions: {
        GetAccessiblePages: ({commit, rootState}) => {            
            return new Promise((resolve, reject) => {
                let accessiblePages = [];

                Api.get(END_POINT + rootState.login.signedUser.id)
                .then((response) => {
                    let pages = [];
                    
                    response.data.map((item) => {
                        pages.push(item.page);
                        /* ***** dashboard pages ******* */
                        if (item.page == "Dashboard") {
                            pages.push("Statistiques de vente");
                            pages.push("État du bon de livraison");
                            // ...
                        }
                    });

                    allPages.map((item) => {
                        pages.forEach(page => {
                            if (item.text === page) accessiblePages.push(item);      
                        });
                    });

                    localStorage.setItem("Pages", JSON.stringify(accessiblePages));
                    commit("setPages", accessiblePages);

                    resolve(response.data);
                })
                .catch((error) => {
                    localStorage.removeItem('User');
                    localStorage.removeItem('UserToken');
                    commit("login/setSignedUser", null);
                    reject(error);
                });
                
            })
        }
    }
};
export default pages