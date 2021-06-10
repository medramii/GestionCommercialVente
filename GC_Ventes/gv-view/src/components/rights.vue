<template>
  <div>
      <div class="dx-fieldset">
        <div class="dx-field">
          <div class="dx-field-label" style="font-size: 16px;">Group</div>
          <div class="dx-field-value">
            <DxSelectBox
              :search-enabled="true"
              :data-source="getGroups()"
              display-expr="name"
              value-expr="id"
              @value-changed="onSelectGroup"
            />
          </div>
        </div>
      </div>
    <DxDataGrid
      :show-borders="true"
      :data-source="getRights()"
      :remote-operations="true"
      :repaint-changes-only="true"
      @saving="onSaving"
    >
      <DxEditing
          :allow-updating="true"
          mode="batch"
      />
      <DxColumn
        :width="50"
        data-field="idPage"
        caption="Id"
      />
      <DxColumn
        data-field="Page"
      />
      <DxColumn
        data-field="hasAccess"
        caption="Has access ??"
      />
    </DxDataGrid>
  </div>
</template>
<script>

import {DxDataGrid, DxEditing, DxColumn} from 'devextreme-vue/data-grid';
import { DxSelectBox } from 'devextreme-vue/select-box';

import {mapGetters} from "vuex"

export default {
  components: {
    DxDataGrid,
    DxEditing,
    DxSelectBox,
    DxColumn
  },
  data() {
    return {
    };
  },
  methods: {
    ...mapGetters(
      {
        getRights: "groupsAccessRights/getAccessRights",
        getGroups: "groupsAccessRights/getGroups",
      },
    ),
    setGroups: function() {
      this.$store.dispatch('groupsAccessRights/GetGroups');
    },
    setRights: function(idGroup) {
      this.$store.dispatch('groupsAccessRights/GetGroupAccessRights', idGroup)
    },
    updateRights: function(payload) {
      this.$store.dispatch('groupsAccessRights/UpdateGroupAccessRights', payload)
    },
    onSelectGroup: function(e) {
      this.setRights(e.value);
    },
    onSaving: function(e) {
      console.log("Saving....");
      e.changes.forEach(element => {
        let updated = {
          "id": element.key.id,
          "idGoup": element.key.idGoup,
          "idPage": element.key.idPage,
          "droit": element.data.hasAccess
        };
        let payload = {
          "id": updated.id,
          "data": updated
        }
        this.updateRights(payload);
      });
    }
  },
  mounted() {
    this.setGroups();
  }
};
</script>
