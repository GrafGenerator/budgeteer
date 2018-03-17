import { Reducer } from 'redux';
import { ResourceEntryCategory } from "../models/domain/ResourceEntryCategory";

// ===== State =====

export interface ResourceEntryCategoriesState {
    items: ResourceEntryCategory[];
}

const initialState = {
  items: []
};

// ===== Action names =====
const LOAD_RESOURCE_ENTRY_CATEGORIES = "resource-entry-categories/load";
const LOAD_RESOURCE_ENTRY_CATEGORIES_SUCCESSFUL = "resource-entry-categories/load-sussessful";
const LOAD_RESOURCE_ENTRY_CATEGORIES_FAILED = "resource-entry-categories/load-failed";

// ===== Actions =====

interface LoadResourceEntryCategoriesAction { type: typeof LOAD_RESOURCE_ENTRY_CATEGORIES }
interface LoadResourceEntryCategoriesSuccessfulAction { type: typeof LOAD_RESOURCE_ENTRY_CATEGORIES_SUCCESSFUL }
interface LoadResourceEntryCategoriesFailedAction { type: typeof LOAD_RESOURCE_ENTRY_CATEGORIES_FAILED }

type KnownAction = LoadResourceEntryCategoriesAction
  | LoadResourceEntryCategoriesSuccessfulAction
  | LoadResourceEntryCategoriesFailedAction;

// ===== Action creators =====

export const actionCreators = {
    load: () => <LoadResourceEntryCategoriesAction>{ type: LOAD_RESOURCE_ENTRY_CATEGORIES },
    successful: () => <LoadResourceEntryCategoriesSuccessfulAction>{ type: LOAD_RESOURCE_ENTRY_CATEGORIES_SUCCESSFUL },
    failed: () => <LoadResourceEntryCategoriesFailedAction>{ type: LOAD_RESOURCE_ENTRY_CATEGORIES_FAILED }
};

// ===== Reducer =====

export const reducer: Reducer<ResourceEntryCategoriesState> =
  (state: ResourceEntryCategoriesState = initialState, action: KnownAction) => {
    switch (action.type) {
        case LOAD_RESOURCE_ENTRY_CATEGORIES:
            return state;
        case LOAD_RESOURCE_ENTRY_CATEGORIES_SUCCESSFUL:
            return state;
        case LOAD_RESOURCE_ENTRY_CATEGORIES_FAILED:
            return state;
        default:
            // The following line guarantees that every action in the KnownAction union has been covered by a case above
            const exhaustiveCheck: never = action;
    }

    // For unrecognized actions (or in cases where actions have no effect), must return the existing state
    //  (or default initial state if none was supplied)
    return state || initialState;
};
