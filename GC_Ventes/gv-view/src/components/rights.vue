<template>
  <div>
      <div class="dx-fieldset">
        <div class="dx-field">
          <div class="dx-field-label" style="font-size: 16px;">Group</div>
          <div class="dx-field-value">
            <DxSelectBox
              :search-enabled="true"
              :value="getGroups()[0]"
              :data-source="getGroups()"
              @value-changed="onValueChanged" 
            />
          </div>
        </div>
      </div>
    <DxDataGrid
      :show-borders="true"
      :data-source="getRights()"
    >
      <DxEditing
          :allow-updating="true"
          mode="cell"
      />
      <DxColumn
        :width="50"
        data-field="Id"
      />
      <DxColumn
        data-field="Page"
      />
      <DxColumn
        data-field="Has access ??"
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
    setRights: function(group) {
      this.$store.dispatch('groupsAccessRights/GetGroupAccessRights', group)
    },
    onValueChanged: function(e) {
      this.setRights(e.value);
    }
  },
  mounted() {
    this.setGroups();
  }
};
</script>
