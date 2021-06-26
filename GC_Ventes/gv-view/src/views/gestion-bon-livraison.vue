<template>
  <div>
    <form id="form-container" class="content-block" @submit.prevent="SaveBl()">
      <DxForm :form-data="getBl" id="form" :col-count="3">
        <DxItem :col-span="2">
          <template #default>
            <div>
              <DxButton
                icon="arrowleft"
                type="default"
                styling-mode="text"
                @click="this.$router.go(-1)"
                style="
                  margin-bottom: 15px;
                  padding-right: 0px;
                  border-right-width: 5px;
                  margin-right: 5px;
                "
              />
              <h2 style="display: contents">{{ action }} bon de livraison</h2>
            </div>
          </template>
        </DxItem>
        <DxButtonItem
          :button-options="buttonOptions"
          horizontal-alignment="right"
        />
        <DxItem
          :editor-options="{ value: getNextBl, disabled: true }"
          data-field="numBl"
        />
        <DxItem
          :editor-options="{
            value: getBl.codeClient,
            searchEnabled: true,
            items: getClients,
            displayExpr: 'raisonSociale',
            valueExpr: 'codeClient',
          }"
          data-field="codeClient"
          editor-type="dxSelectBox"
        >
          <DxRequiredRule message="Client est obligatoire" />
        </DxItem>
        <DxItem
          :editor-options="{
            value: getBl.idDestination,
            searchEnabled: true,
            items: getVilles,
            displayExpr: 'ville',
            valueExpr: 'idVille',
          }"
          data-field="Destination"
          editor-type="dxSelectBox"
        >
          <DxRequiredRule message="Destination est obligatoire" />
        </DxItem>
        <DxItem
          :editor-options="{
            value: 'Local',
            items: ['Local', 'Export'],
          }"
          editor-type="dxSelectBox"
          data-field="typeVente"
        >
          <DxRequiredRule message="Type de vente est obligatoire" />
        </DxItem>
        <DxItem
          :editor-options="{
            value: 'MAD',
            items: ['MAD', 'USD', 'EUR'],
          }"
          editor-type="dxSelectBox"
          data-field="devise"
        >
          <DxRequiredRule message="Devise est obligatoire" />
        </DxItem>
        <DxItem
          data-field="tauxDeChange"
          editor-type="dxNumberBox"
          :editor-options="{ value: 1, min: '1' }"
        >
          <DxRequiredRule message="Taux de change est obligatoire" />
        </DxItem>
        <DxItem data-field="dateBl" editor-type="dxDateBox">
          <DxRequiredRule message="La date est obligatoire" />
        </DxItem>
        <DxItem :col-span="2" data-field="observation" />
      </DxForm>
    </form>

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
        aria-required="true"
        data-field="codeArticle"
        caption="Article"
        editor-type="dxSelectBox"
        :editor-options="{
          value: '',
          searchEnabled: true,
          items: getArticles,
          displayExpr: 'designation',
          valueExpr: 'codeArticle',
        }"
      >
        <DxRequiredRule message="L'article est obligatoire" />
      </DxColumn>
      <DxColumn
        data-field="codeMagasin"
        caption="Magasin"
        editor-type="dxSelectBox"
        :editor-options="{
          value: '',
          searchEnabled: true,
          items: getMagasins,
          displayExpr: 'designation',
          valueExpr: 'codeMagasin',
        }"
      >
        <DxRequiredRule message="Le magain est obligatoire" />
      </DxColumn>
      <DxColumn
        data-field="qte"
        caption="Quantité"
        editor-type="dxNumberBox"
        :editor-options="{ min: '1' }"
      >
        <DxRequiredRule message="La quantité est obligatoire" />
      </DxColumn>
      <DxColumn
        data-field="prix"
        caption="Prix unitaire (Dhs)"
        editor-type="dxNumberBox"
        :editor-options="{ min: '0' }"
      >
        <DxRequiredRule message="Le prix est obligatoire" />
      </DxColumn>
    </DxDataGrid>
  </div>
</template>

<script>
import {
  DxForm,
  DxItem,
  DxRequiredRule,
  DxButtonItem,
} from "devextreme-vue/form";
import { DxDataGrid, DxEditing, DxColumn } from "devextreme-vue/data-grid";
import DxButton from "devextreme-vue/button";
import notify from "devextreme/ui/notify";
import { mapActions, mapGetters } from "vuex";

export default {
  components: {
    DxForm,
    DxItem,
    DxRequiredRule,
    DxButtonItem,
    DxButton,
    DxDataGrid,
    DxEditing,
    DxColumn,
  },
  data() {
    return {
      action: this.$route.params.action,
      id: this.$route.params.id,
      buttonOptions: {
        text: "Sauvegarder",
        type: "default",
        stylingMode: "text",
        useSubmitBehavior: true,
      },
    };
  },
  computed: {
    ...mapGetters({
      getBl: "bonLivraison/getBlInUse",
      getNextBl: "bonLivraison/getNextBl",
      getLignesBl: "bonLivraison/getLignesBl",
      getClients: "config/getClients",
      getVilles: "config/getVilles",
      getArticles: "config/getArticles",
      getMagasins: "config/getMagasins",
    }),
  },
  methods: {
    ...mapActions({
      initDataForAdd: "bonLivraison/initDataForAdd",
      initDataForUpdate: "bonLivraison/initDataForUpdate",
      addBl: "bonLivraison/addBL",
      configData: "config/initConfig",
    }),
    // initDataForUpdate(id) {
    //   this.$store.dispatch("bonLivraison/initDataForUpdate", id);
    // },
    dataValidation() {
      if (this.getLignesBl.length < 1) {
        return "La livraison doit contenir au moins un article...!!?";
      } else return true;
    },
    SaveBl() {
      if (this.dataValidation() === true) {
        if (this.action == "Ajouter") {
          // this.$store.dispatch('bonLivraison/addBL');
          this.addBl()
            .then(() => {
              notify(
                "Le bon de livraison a etes ajouté avec success...!!",
                "success",
                2000
              );
              this.$router.go(-1);
            })
            .catch(() => {
              notify("Echec..!!", "error", 1500);
            });
        } else if (this.action == "Modifier" && this.id > 0) {
          this.$store.dispatch("bonLivraison/editBL", this.id);
          notify(
            "Le bon de livraison a etes modifié avec success...!!",
            "success",
            2000
          );
          this.$router.go(-1);
        }
      } else {
        notify(this.dataValidation(), "error", 2000);
      }
    },
  },
  beforeMount() {
    if (this.action == "Ajouter" && this.id == "nouveau") {
      this.configData();
      this.initDataForAdd();
    } else if (this.action == "Modifier" && this.id > 0) {
      this.configData();
      this.initDataForUpdate(this.id)
        .catch(() => {
          this.$router.back();
        });
    } else {
      this.$router.back();
    }
  },
  beforeUnmount() {
    this.$store.commit("bonLivraison/setBlInUse", []);
    this.$store.commit("bonLivraison/setLignesBl", []);
    this.$store.commit("bonLivraison/setNextBl", "");
  },
};
</script>