import Vue from "vue";
import App from "./App.vue";

// Bulma CSS framework (imports Sass files)
import "bulma";

Vue.config.productionTip = false;

new Vue({
  render: (h) => h(App)
}).$mount("#app");
