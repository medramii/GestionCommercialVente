<template>
  <div>
    <h2 class="content-block">Tasks</h2>

    <dx-data-grid
      style="margin-inline: 40px;"
      class="dx-card"
      :data-source="dataSourceConfig"
      :focused-row-index="0"
      :show-borders="false"
      :focused-row-enabled="true"
      :column-auto-width="true"
      :column-hiding-enabled="true"
    >
      <dx-paging :page-size="10" />
      <dx-pager :show-page-size-selector="true" :show-info="true" />
      <dx-filter-row :visible="true" />

      <dx-column
        data-field="Task_Subject"
        caption="Group"
        :hiding-priority="0"
      />

      <dx-column
        data-field="Task_Status"
        caption="Page"
        :hiding-priority="0"
      />

      <dx-column
        data-field="Task_Completion"
        caption="Has Acces ?"
        :hiding-priority="0"
      />

    </dx-data-grid>
  </div>
</template>

<script>
import "devextreme/data/odata/store";
import DxDataGrid, {
  DxColumn,
  DxFilterRow,
  DxPager,
  DxPaging
} from "devextreme-vue/data-grid";

const priorities = [
  { name: "High", value: 4 },
  { name: "Urgent", value: 3 },
  { name: "Normal", value: 2 },
  { name: "Low", value: 1 }
];

export default {
  data() {
    return {
      groups: ["test1", "test2", "test3",]
    }
  },
  setup() {
    const dataSourceConfig = {
      store: {
        type: "odata",
        key: "Task_ID",
        url: "https://js.devexpress.com/Demos/DevAV/odata/Tasks"
      },
      expand: "ResponsibleEmployee",
      select: [
        "Task_ID",
        "Task_Subject",
        "Task_Status",
        "Task_Completion",
      ]
    };
    return {
      dataSourceConfig,
      priorities
    };
  },
  components: {
    DxDataGrid,
    DxColumn,
    DxFilterRow,
    DxPager,
    DxPaging
  }
};
</script>
