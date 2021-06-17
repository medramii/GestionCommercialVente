<template>
  <div>
    <h2 class="content-block">
      {{action}} bon de livraison
    </h2>
    <div id="form-container" class="content-block">
      <button @click="SaveBl()">Save</button>
      <DxForm
        :form-data="getBl"
        id="form"
        :col-count="3"
      >
        <DxItem
          :editor-options="{value: getNextBl, disabled: true}"
          data-field="numBl"
        />
        <DxItem
          :editor-options="{
            value: getBl.codeClient,
            searchEnabled: true,
            items: getClients,
            displayExpr: 'codeClient', // here will be the raisonSocial instead of codeClient
            valueExpr: 'codeClient'
          }"
          data-field="codeClient"
          editor-type="dxSelectBox"
        />
        <DxItem
          :editor-options="{
            value: getBl.idDestination,
            searchEnabled: true,
            items: getVilles,
            displayExpr: 'ville',
            valueExpr: 'idVille'
          }"
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
      class="content-block"
      id="grid-container"
      :column-auto-width="true"
      :column-hiding-enabled="true"
      :show-borders="false"
      :data-source="getLignesBl"
    >
      <DxEditing
        :allow-adding="true"
        :allow-updating="true"
        :allow-deleting="true"
        refresh-mode="repaint"
        mode="batch"
      />
      <DxColumn
        data-field="codeArticle"
        caption="Article"
        editor-type="dxSelectBox"
        :editor-options="{
            value: '',
            searchEnabled: true,
            items: getArticles,
            displayExpr: 'designation',
            valueExpr: 'codeArticle'
        }"
      />
      <DxColumn
        data-field="codeMagasin"
        caption="Magasin"
        editor-type="dxSelectBox"
        :editor-options="{
            value: '',
            searchEnabled: true,
            items: getMagasins,
            displayExpr: 'designation',
            valueExpr: 'codeMagasin'
        }"
      />
      <DxColumn
        data-field="qte"
        caption="Quantité"
        data-type="number"
      />
      <DxColumn
        data-field="prix"
        caption="Prix unitaire (Dhs)"
        data-type="number"
      />
    </DxDataGrid>
  </div>
</template>

<script>
import { DxForm, DxItem } from 'devextreme-vue/form';
import {
  DxDataGrid,
  DxEditing,
  DxColumn,
} from 'devextreme-vue/data-grid';
import {mapActions, mapGetters} from "vuex"

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
    }
  },
  computed: {
    ...mapGetters(
      {
        getBl: "bonLivraison/getBlInUse",
        getNextBl: "bonLivraison/getNextBl",
        getLignesBl: "bonLivraison/getLignesBl",
        getClients: "bonLivraison/getClients",
        getVilles: "bonLivraison/getVilles",
        getArticles: "bonLivraison/getArticles",
        getMagasins: "bonLivraison/getMagasins",
      },
    ),
  },
  methods: {
    ...mapActions(
      {
        initDataForAdd: "bonLivraison/initDataForAdd",
      }
    ),
    initDataForUpdate(id) {
      this.$store.dispatch('bonLivraison/initDataForUpdate', id)
    },
    SaveBl() {
      if (this.action == "Ajouter") {
        this.$store.dispatch('bonLivraison/addBL');
      }
      else if (this.action == "Modifier" && this.id > 0) {
        this.$store.dispatch('bonLivraison/editBL', this.id);
      }
    },
  },
  beforeMount() {
    if (this.action == "Ajouter") {
      console.log("Ajouter...");
      this.initDataForAdd();
    }
    else if (this.action == "Modifier" && this.id > 0) {
      console.log("Modifier...");
      this.initDataForUpdate(this.id);
    }
    else {
      console.log("Error 404 not found...!!");
    }
  }
};
</script>