import axios from 'axios'
const defaultUser = {
  username: 'Romerro Med',
  avatarUrl: 'https://js.devexpress.com/Demos/WidgetsGallery/JSDemos/images/employees/06.png'
};
export default {
  _user: defaultUser,
  _token: String,
  loggedIn() {
    return !!this._user;
  },

  async logIn(username, password) {
    try {
      // Send request
      axios.post("https://localhost:44381/api/login?username=".concat(username) + "&password=".concat(password))
       .then(res => {
         this._token = res.data.token;
         console.log(this._token);
       })
       .catch(error => console.log(error));
      
      this._user = { ...defaultUser, username };

      return {
        isOk: true,
        data: this._user
      };
    }
    catch {
      return {
        isOk: false,
        message: "Authentication failed"
      };
    }
  },

  async logOut() {
    // var AuthStr = "Bearer ".concat(this._token);
    // axios.get("https://localhost:44381/api/login/logout",
    // { 'headers': { 'Authorization': AuthStr } })
    // .catch(error => console.log(error));
    // this._user = null;
  },

  async getUser() {
    try {
      // var AuthStr = "Bearer ".concat(this._token);
      // axios.get("https://localhost:44381/api/login/getCurrentUser",
      // { 'headers': { 'Authorization': AuthStr } })
      // .then(res => console.log(res.data))
      // .catch(error => console.log(AuthStr+"\n"+error));

      return {
        isOk: true,
        data: this._user
      };
    }
    catch {
      return {
        isOk: false
      };
    }
  }
};
