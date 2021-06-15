<template>
  <div>
    <h2 class="content-block" v-if="id<-1">{{id}}</h2>
    <h2 class="content-block">
      {{action}} bon de livraison
    </h2>
    <div id="form-container" class="content-block">
      <button @click="log()">click</button>
      <DxForm
        :form-data="getBl"
        id="form"
        :col-count="3"
      >
        <DxItem
          :editor-options="{disabled: true}"
          data-field="numBl"
        />
        <DxItem
          :editor-options="{value: '', searchEnabled: true,}"
          data-field="codeClient"
          editor-type="dxSelectBox"
        />
        <DxItem
          :editor-options="{value: null, width: '100%'}"
          data-field="Destination"
          editor-type="dxSelectBox"
        />
        <DxItem
          data-field="typeVente"
        />
        <DxItem
          data-field="Devise"
        />
        <DxItem
          data-field="tauxDeChange"
        />
        <DxItem
          data-field="dateBl"
          editor-type="dxDateBox"
        />
        <DxItem
          :col-span="2"
          data-field="observation"
        />
      </DxForm>
    </div>
      
    <DxDataGrid
      :height="auto"
      class="content-block"
      id="grid-container"
      :column-auto-width="true"
      :column-hiding-enabled="true"
      :ref="gridRefName"
      :show-borders="false"
      :data-source="articles"
    >
      <DxEditing
        :allow-adding="true"
        mode="batch"
      />
      <DxColumn
        data-field="codeArticle"
        caption="Article"
        editor-type="dxSelectBox"
        :editor-options="{value: '', searchEnabled: true, items: positions}"
      />
      <DxColumn
        data-field="codeMgasin"
        caption="Magasin"
        editor-type="dxSelectBox"
        :editor-options="{value: '', searchEnabled: true, items: positions}"
      />
      <DxColumn
        data-field="qte"
        caption="Quantité"
      />
      <DxColumn
        data-field="prix"
        caption="Prix unitaire (Dhs)"
      />
    </DxDataGrid>
  </div>
</template>

<script>
import CustomStore from 'devextreme/data/custom_store';
import { DxForm, DxItem } from 'devextreme-vue/form';
import {
  DxDataGrid,
  DxEditing,
  DxColumn,
} from 'devextreme-vue/data-grid';
import {mapGetters} from "vuex"

export default {
  components: {
    DxForm,
    DxItem, 
    DxDataGrid,
    DxEditing,
    DxColumn,
  },
  data() {
    return {
      action: this.$route.params.action,
      id: this.$route.params.id,
      gridRefName: 'grid',
      refreshMode: 'full',
      dataSource: {
        "numBl": "BL-10",
        "codeClient": "",
        "Destination": "",
        "dateBl": "",
        "typeVente": "",
        "Devise": "",
        "tauxDeChange": "",
        "observation": "",
      },
      articles: new CustomStore({
        load: () => {
          return [];
        },
      }),
    }
  },
  methods: {
    ...mapGetters(
      {
        getBl: "bonLivraison/getBlInUse",
      },
    ),
    log: function() {
      console.log(this.getBl());
    }
  },
  beforeMount() {
    console.log(this.action);
    console.log(this.getBl());
  }
};
</script>