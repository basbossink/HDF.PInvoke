/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Copyright by The HDF Group.                                               *
 * Copyright by the Board of Trustees of the University of Illinois.         *
 * All rights reserved.                                                      *
 *                                                                           *
 * This file is part of HDF5.  The full HDF5 copyright notice, including     *
 * terms governing use, modification, and redistribution, is contained in    *
 * the files COPYING and Copyright.html.  COPYING can be found at the root   *
 * of the source code distribution tree; Copyright.html can be found at the  *
 * root level of an installed copy of the electronic HDF5 document set and   *
 * is linked from the top-level documents page.  It can also be found at     *
 * http://hdfgroup.org/HDF5/doc/Copyright.html.  If you do not have          *
 * access to either file, you may request a copy from help@hdfgroup.org.     *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using hbool_t = System.Int32;
using herr_t = System.Int32;
using hsize_t = System.UInt64;
using htri_t = System.Int32;
using size_t = System.IntPtr;

#if HDF5_VER1_10
using hid_t = System.Int64;
#else
using hid_t = System.Int32;
#endif

namespace HDF.PInvoke
{
    public unsafe sealed partial class H5P
    {
        static H5DLLImporter m_importer;

        static hid_t? H5P_CLS_ROOT_g;

        public static hid_t ROOT 
        {
            get
            {
                if (!H5P_CLS_ROOT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_ROOT_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_ROOT_g = val;
                    }
                }
                return H5P_CLS_ROOT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_OBJECT_CREATE_g;

        public static hid_t OBJECT_CREATE 
        {
            get
            {
                if (!H5P_CLS_OBJECT_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_OBJECT_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_OBJECT_CREATE_g = val;
                    }
                }
                return H5P_CLS_OBJECT_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_FILE_CREATE_g;

        public static hid_t FILE_CREATE 
        {
            get
            {
                if (!H5P_CLS_FILE_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_FILE_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_FILE_CREATE_g = val;
                    }
                }
                return H5P_CLS_FILE_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_FILE_ACCESS_g;

        public static hid_t FILE_ACCESS 
        {
            get
            {
                if (!H5P_CLS_FILE_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_FILE_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_FILE_ACCESS_g = val;
                    }
                }
                return H5P_CLS_FILE_ACCESS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_DATASET_CREATE_g;

        public static hid_t DATASET_CREATE 
        {
            get
            {
                if (!H5P_CLS_DATASET_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_DATASET_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_DATASET_CREATE_g = val;
                    }
                }
                return H5P_CLS_DATASET_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_DATASET_ACCESS_g;

        public static hid_t DATASET_ACCESS 
        {
            get
            {
                if (!H5P_CLS_DATASET_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_DATASET_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_DATASET_ACCESS_g = val;
                    }
                }
                return H5P_CLS_DATASET_ACCESS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_DATASET_XFER_g;

        public static hid_t DATASET_XFER 
        {
            get
            {
                if (!H5P_CLS_DATASET_XFER_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_DATASET_XFER_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_DATASET_XFER_g = val;
                    }
                }
                return H5P_CLS_DATASET_XFER_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_FILE_MOUNT_g;

        public static hid_t FILE_MOUNT 
        {
            get
            {
                if (!H5P_CLS_FILE_MOUNT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_FILE_MOUNT_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_FILE_MOUNT_g = val;
                    }
                }
                return H5P_CLS_FILE_MOUNT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_GROUP_CREATE_g;

        public static hid_t GROUP_CREATE 
        {
            get
            {
                if (!H5P_CLS_GROUP_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_GROUP_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_GROUP_CREATE_g = val;
                    }
                }
                return H5P_CLS_GROUP_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_GROUP_ACCESS_g;

        public static hid_t GROUP_ACCESS 
        {
            get
            {
                if (!H5P_CLS_GROUP_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_GROUP_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_GROUP_ACCESS_g = val;
                    }
                }
                return H5P_CLS_GROUP_ACCESS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_DATATYPE_CREATE_g;

        public static hid_t DATATYPE_CREATE 
        {
            get
            {
                if (!H5P_CLS_DATATYPE_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_DATATYPE_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_DATATYPE_CREATE_g = val;
                    }
                }
                return H5P_CLS_DATATYPE_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_DATATYPE_ACCESS_g;

        public static hid_t DATATYPE_ACCESS 
        {
            get
            {
                if (!H5P_CLS_DATATYPE_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_DATATYPE_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_DATATYPE_ACCESS_g = val;
                    }
                }
                return H5P_CLS_DATATYPE_ACCESS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_STRING_CREATE_g;

        public static hid_t STRING_CREATE 
        {
            get
            {
                if (!H5P_CLS_STRING_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_STRING_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_STRING_CREATE_g = val;
                    }
                }
                return H5P_CLS_STRING_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_ATTRIBUTE_CREATE_g;

        public static hid_t ATTRIBUTE_CREATE 
        {
            get
            {
                if (!H5P_CLS_ATTRIBUTE_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_ATTRIBUTE_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_ATTRIBUTE_CREATE_g = val;
                    }
                }
                return H5P_CLS_ATTRIBUTE_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_OBJECT_COPY_g;

        public static hid_t OBJECT_COPY 
        {
            get
            {
                if (!H5P_CLS_OBJECT_COPY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_OBJECT_COPY_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_OBJECT_COPY_g = val;
                    }
                }
                return H5P_CLS_OBJECT_COPY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_LINK_CREATE_g;

        public static hid_t LINK_CREATE 
        {
            get
            {
                if (!H5P_CLS_LINK_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_LINK_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_LINK_CREATE_g = val;
                    }
                }
                return H5P_CLS_LINK_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_CLS_LINK_ACCESS_g;

        public static hid_t LINK_ACCESS 
        {
            get
            {
                if (!H5P_CLS_LINK_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_CLS_LINK_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_CLS_LINK_ACCESS_g = val;
                    }
                }
                return H5P_CLS_LINK_ACCESS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_FILE_CREATE_g;

        public static hid_t LST_FILE_CREATE 
        {
            get
            {
                if (!H5P_LST_FILE_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_FILE_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_FILE_CREATE_g = val;
                    }
                }
                return H5P_LST_FILE_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_FILE_ACCESS_g;

        public static hid_t LST_FILE_ACCESS 
        {
            get
            {
                if (!H5P_LST_FILE_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_FILE_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_FILE_ACCESS_g = val;
                    }
                }
                return H5P_LST_FILE_ACCESS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_DATASET_CREATE_g;

        public static hid_t LST_DATASET_CREATE 
        {
            get
            {
                if (!H5P_LST_DATASET_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_DATASET_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_DATASET_CREATE_g = val;
                    }
                }
                return H5P_LST_DATASET_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_DATASET_ACCESS_g;

        public static hid_t LST_DATASET_ACCESS 
        {
            get
            {
                if (!H5P_LST_DATASET_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_DATASET_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_DATASET_ACCESS_g = val;
                    }
                }
                return H5P_LST_DATASET_ACCESS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_DATASET_XFER_g;

        public static hid_t LST_DATASET_XFER 
        {
            get
            {
                if (!H5P_LST_DATASET_XFER_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_DATASET_XFER_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_DATASET_XFER_g = val;
                    }
                }
                return H5P_LST_DATASET_XFER_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_FILE_MOUNT_g;

        public static hid_t LST_FILE_MOUNT 
        {
            get
            {
                if (!H5P_LST_FILE_MOUNT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_FILE_MOUNT_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_FILE_MOUNT_g = val;
                    }
                }
                return H5P_LST_FILE_MOUNT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_GROUP_CREATE_g;

        public static hid_t LST_GROUP_CREATE 
        {
            get
            {
                if (!H5P_LST_GROUP_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_GROUP_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_GROUP_CREATE_g = val;
                    }
                }
                return H5P_LST_GROUP_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_GROUP_ACCESS_g;

        public static hid_t LST_GROUP_ACCESS 
        {
            get
            {
                if (!H5P_LST_GROUP_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_GROUP_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_GROUP_ACCESS_g = val;
                    }
                }
                return H5P_LST_GROUP_ACCESS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_DATATYPE_CREATE_g;

        public static hid_t LST_DATATYPE_CREATE 
        {
            get
            {
                if (!H5P_LST_DATATYPE_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_DATATYPE_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_DATATYPE_CREATE_g = val;
                    }
                }
                return H5P_LST_DATATYPE_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_DATATYPE_ACCESS_g;

        public static hid_t LST_DATATYPE_ACCESS 
        {
            get
            {
                if (!H5P_LST_DATATYPE_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_DATATYPE_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_DATATYPE_ACCESS_g = val;
                    }
                }
                return H5P_LST_DATATYPE_ACCESS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_ATTRIBUTE_CREATE_g;

        public static hid_t LST_ATTRIBUTE_CREATE 
        {
            get
            {
                if (!H5P_LST_ATTRIBUTE_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_ATTRIBUTE_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_ATTRIBUTE_CREATE_g = val;
                    }
                }
                return H5P_LST_ATTRIBUTE_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_OBJECT_COPY_g;

        public static hid_t LST_OBJECT_COPY 
        {
            get
            {
                if (!H5P_LST_OBJECT_COPY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_OBJECT_COPY_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_OBJECT_COPY_g = val;
                    }
                }
                return H5P_LST_OBJECT_COPY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_LINK_CREATE_g;

        public static hid_t LST_LINK_CREATE 
        {
            get
            {
                if (!H5P_LST_LINK_CREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_LINK_CREATE_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_LINK_CREATE_g = val;
                    }
                }
                return H5P_LST_LINK_CREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5P_LST_LINK_ACCESS_g;

        public static hid_t LST_LINK_ACCESS 
        {
            get
            {
                if (!H5P_LST_LINK_ACCESS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5P_LST_LINK_ACCESS_ID_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5P_LST_LINK_ACCESS_g = val;
                    }
                }
                return H5P_LST_LINK_ACCESS_g.GetValueOrDefault();
            }
        }
    }
}
