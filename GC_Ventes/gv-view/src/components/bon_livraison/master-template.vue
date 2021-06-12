<template>
  <DxTabPanel
    :data-source="tabs"
    :loop="true"
    :animation-enabled="true"
    :swipe-enabled="true"
  >
    <template #title="{ data: tab }">
      <span> {{tab.title}} </span>
    </template>
    <template #item="{ data: tab }">
      <div class="tabpanel-item">
        <Article v-if="tab.title === 'Articles'" :articles="BlData"></Article>
        <Client v-else-if="tab.title === 'Client'" :client="BlData"></Client>
        <Details v-else-if="tab.title === 'Details'" :details="BlData"></Details>
      </div>
    </template>
  </DxTabPanel>
</template>

<script>
import DxTabPanel from 'devextreme-vue/tab-panel';

import Article from "./articles.vue"
import Client from './client.vue';
import Details from './details.vue';

export default {
  props: {
    BlData: {
      type: Object,
      default: ()=>{}
    }
  },
  components: {
    DxTabPanel,
    Article,
    Client,
    Details
  },
  data() {
    return {
      tabs: [
        {
          "title": "Articles", 
          "data": this.BlData
        },
        {
          "title": "Client",
          "data": this.BlData
        },
        {
          "title": "Details",
          "data": this.BlData
        },
      ],
    };
  }
};
</script>

<style>
.tabpanel-item {
    height: 200px;
    user-select: none;
    margin: 25px;
    padding-left: 25px;
    padding-top: 25px;
}

.mobile .tabpanel-item {
    padding-top: 10px;
}

.tabpanel-item  > div {
    float: left;
    padding: 0 85px 10px 10px
}

.tabpanel-item  p {
    font-size: 16px;
    margin: 0;
}

.item-box {
    font-size: 16px;
    margin: 15px 0 45px 10px;
}

.caption {
    font-size: 18px;
    font-weight: 500;
}

.option {
    margin-top: 10px;
}
</style>
