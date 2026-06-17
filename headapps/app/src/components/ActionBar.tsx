import { addEscape } from "@/actions/add-escape";
import { addExplorer } from "@/actions/add-explorer";

export const ActionBar = () => {
  return (
    <div className="mb-4 flex w-full justify-end gap-2">
      <form action={addExplorer}>
        <button
          type="submit"
          className="rounded bg-blue-500 px-4 py-2 font-semibold text-white hover:bg-blue-600"
        >
          Add Explorer
        </button>
      </form>
      <form action={addEscape}>
        <button
          type="submit"
          className="rounded bg-blue-500 px-4 py-2 font-semibold text-white hover:bg-blue-600"
        >
          Add Escape
        </button>
      </form>
    </div>
  );
};
